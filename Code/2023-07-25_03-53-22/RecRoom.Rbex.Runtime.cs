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
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PhysicsManager : SingletonMonoBehaviour<PhysicsManager>
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static NHBIDAMCDOH UpdateAfterFixedUpdateRan;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private int IHOGLFKIDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int FMMGBAHPEHC;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x71A2E20", Offset = "0x71A1E20", VA = "0x1871A2E20")]
		protected void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71A2E60", Offset = "0x71A1E60", VA = "0x1871A2E60")]
		protected void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71A2E40", Offset = "0x71A1E40", VA = "0x1871A2E40")]
		protected void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsNotYetUpdated([Optional] string HJJLMCEMDKN, [Optional] UnityEngine.Object AEOEKGNDHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
		[Conditional("UNITY_ASSERTIONS")]
		public void AssertLateColliderPositionsAlreadyUpdated([Optional] string HJJLMCEMDKN, [Optional] UnityEngine.Object AEOEKGNDHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71A2F50", Offset = "0x71A1F50", VA = "0x1871A2F50")]
		public PhysicsManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NHHCNDLEKPN
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private class BGFJKLJPCBJ : FBBNGPOGPDF, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xFAEC20", Offset = "0xFADC20", VA = "0x180FAEC20", Slot = "4")]
		public Vector3 NCJNHHNFGBI()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xFAEC20", Offset = "0xFADC20", VA = "0x180FAEC20", Slot = "5")]
		public Vector3 PIFCIBMMDHL()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public BGFJKLJPCBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static FBBNGPOGPDF CIHCLJCBBAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x719DF80", Offset = "0x719CF80", VA = "0x18719DF80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[DisallowMultipleComponent]
	public sealed class RigidbodyEx : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly HPPHLHFLMDP GDNAOKLHIMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool FALIGJDNEFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private GKIJIJOABOO CAKIIDPHAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[OFFACMCMMNI(KDNNMHJGNJH.Self, false, false, false)]
		private Rigidbody unityRigidbody;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[OFFACMCMMNI(KDNNMHJGNJH.SelfAndParent, true, false, false)]
		private PhotonView photonView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private OverridableVector3 precomputedCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private OverridableVector3 customCenterOfMass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		[FormerlySerializedAs("forceNoInterpolation")]
		private AFHLDJNIIID physicsInterpolation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		[Tooltip("If checked, this object's Unity Rigidbody will not be stripped when parenting the object to another RigidbodyEx. Only check this on objects that have a Unity Rigidbody by default and who need access to Unity physics events like OnTriggerEnter, OnCollisionEnter, etc. This is sometimes set via script instead of this flag.")]
		private bool keepUnityRigidbodyWhileParented;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5D")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		[Tooltip("If the RigidbodyEx has a parent that is being destroyed, this flag allows this RigidbodyEx to keep the parent set. The default behavior is thatthe parent property is set to null, resetting/clearing the existing parent when it is being destroyed.")]
		private bool keepParentOnParentDestroy;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5E")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		[HideInInspector]
		private bool hasUnityRigidbodyByDefault;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		internal GKIJIJOABOO OGHMAKLGJOG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x71A3C90", Offset = "0x71A2C90", VA = "0x1871A3C90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public IReadOnlyList<RigidbodyEx> LJMGCPOELKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x9768A0", Offset = "0x9758A0", VA = "0x1809768A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RigidbodyEx GJAPAANMBEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x71A5CB0", Offset = "0x71A4CB0", VA = "0x1871A5CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RigidbodyEx LGIBJPCGOGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x71A5C10", Offset = "0x71A4C10", VA = "0x1871A5C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RigidbodyEx DJAGPEDCGHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x71A6890", Offset = "0x71A5890", VA = "0x1871A6890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x71A7D90", Offset = "0x71A6D90", VA = "0x1871A7D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Transform CPEPBHIJGJH
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xA99790", Offset = "0xA98790", VA = "0x180A99790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Transform ODCCNDECCIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA99790", Offset = "0xA98790", VA = "0x180A99790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public EAAMOAHJJCP HGMPDKIENND
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x71A5970", Offset = "0x71A4970", VA = "0x1871A5970")]
			get
			{
				return default(EAAMOAHJJCP);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x71A7530", Offset = "0x71A6530", VA = "0x1871A7530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ACONAACMEEO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x71A5F70", Offset = "0x71A4F70", VA = "0x1871A5F70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DGEAHLNJGHA
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x71A5AF0", Offset = "0x71A4AF0", VA = "0x1871A5AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FBBNGPOGPDF GDMLIKAFCOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x71A5EB0", Offset = "0x71A4EB0", VA = "0x1871A5EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x71A7740", Offset = "0x71A6740", VA = "0x1871A7740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public PCCGNALJHJC IEFFEBPICJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x71A5E50", Offset = "0x71A4E50", VA = "0x1871A5E50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x71A76D0", Offset = "0x71A66D0", VA = "0x1871A76D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool ICIMBBIGOLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x71A5DA0", Offset = "0x71A4DA0", VA = "0x1871A5DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Rigidbody IIPBJHLJBAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x71A5E00", Offset = "0x71A4E00", VA = "0x1871A5E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EKBGPCJPIFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71A5B50", Offset = "0x71A4B50", VA = "0x1871A5B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x71A75F0", Offset = "0x71A65F0", VA = "0x1871A75F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool NGMCHCDEADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x150D4D0", Offset = "0x150C4D0", VA = "0x18150D4D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x3E5C280", Offset = "0x3E5B280", VA = "0x183E5C280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float LJJHDOLPJOB
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x71A6830", Offset = "0x71A5830", VA = "0x1871A6830")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float FFCIDGEJFPO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x71A67D0", Offset = "0x71A57D0", VA = "0x1871A67D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x71A7D20", Offset = "0x71A6D20", VA = "0x1871A7D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public float DFGAJEGDAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x71A61C0", Offset = "0x71A51C0", VA = "0x1871A61C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x71A79D0", Offset = "0x71A69D0", VA = "0x1871A79D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float LAOKCKEIHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x71A5FD0", Offset = "0x71A4FD0", VA = "0x1871A5FD0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x71A77B0", Offset = "0x71A67B0", VA = "0x1871A77B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool AKFHBEDNOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x71A6DA0", Offset = "0x71A5DA0", VA = "0x1871A6DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x71A8280", Offset = "0x71A7280", VA = "0x1871A8280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 BHFJCPPNKEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x71A65D0", Offset = "0x71A55D0", VA = "0x1871A65D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x71A7B10", Offset = "0x71A6B10", VA = "0x1871A7B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public Vector3 NAOKAKLADHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x71A6ED0", Offset = "0x71A5ED0", VA = "0x1871A6ED0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CollisionDetectionMode KKDLEBCGPIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x71A6100", Offset = "0x71A5100", VA = "0x1871A6100")]
			get
			{
				return default(CollisionDetectionMode);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x71A78F0", Offset = "0x71A68F0", VA = "0x1871A78F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float PBKPBDBPLKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x71A5BB0", Offset = "0x71A4BB0", VA = "0x1871A5BB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x71A7660", Offset = "0x71A6660", VA = "0x1871A7660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public RigidbodyConstraints KNBENOGDALJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x71A6160", Offset = "0x71A5160", VA = "0x1871A6160")]
			get
			{
				return default(RigidbodyConstraints);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x71A7960", Offset = "0x71A6960", VA = "0x1871A7960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public Vector3 OJHKNIDIPEM
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x71A6930", Offset = "0x71A5930", VA = "0x1871A6930")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Vector3 NOIDNCJHFAK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x71A6930", Offset = "0x71A5930", VA = "0x1871A6930")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x71A8070", Offset = "0x71A7070", VA = "0x1871A8070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float CDHAPBHGNKC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x71A66A0", Offset = "0x71A56A0", VA = "0x1871A66A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x71A7BE0", Offset = "0x71A6BE0", VA = "0x1871A7BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float CDMLLOJOHOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x71A6D40", Offset = "0x71A5D40", VA = "0x1871A6D40")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x71A8210", Offset = "0x71A7210", VA = "0x1871A8210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Quaternion BPMEFKHKKEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x71A6A00", Offset = "0x71A5A00", VA = "0x1871A6A00")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x71A7E00", Offset = "0x71A6E00", VA = "0x1871A7E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Quaternion FBEFJDOFLCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x71A6C70", Offset = "0x71A5C70", VA = "0x1871A6C70")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x71A8140", Offset = "0x71A7140", VA = "0x1871A8140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 CKOEIHFJJBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x71A6AD0", Offset = "0x71A5AD0", VA = "0x1871A6AD0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x71A7ED0", Offset = "0x71A6ED0", VA = "0x1871A7ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Quaternion HLBBDPEJNBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x71A6BA0", Offset = "0x71A5BA0", VA = "0x1871A6BA0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x71A7FA0", Offset = "0x71A6FA0", VA = "0x1871A7FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 DIGLJLOIALF
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x71A6E00", Offset = "0x71A5E00", VA = "0x1871A6E00")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x71A82F0", Offset = "0x71A72F0", VA = "0x1871A82F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector3 BEGLMLACECH
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x71A6700", Offset = "0x71A5700", VA = "0x1871A6700")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x71A7C50", Offset = "0x71A6C50", VA = "0x1871A7C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector3 BFOCKHBKDDG
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x71A6030", Offset = "0x71A5030", VA = "0x1871A6030")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x71A7820", Offset = "0x71A6820", VA = "0x1871A7820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Vector3 HALOBGHOELO
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x71A6500", Offset = "0x71A5500", VA = "0x1871A6500")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x71A7A40", Offset = "0x71A6A40", VA = "0x1871A7A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Vector3 PFLPIMMPEGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x71A63D0", Offset = "0x71A53D0", VA = "0x1871A63D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Quaternion LEBLIEFNHNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x71A6300", Offset = "0x71A5300", VA = "0x1871A6300")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector3 AMCFNPOOGAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x71A7070", Offset = "0x71A6070", VA = "0x1871A7070")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Vector3 GIAGAFEJDDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x71A6FA0", Offset = "0x71A5FA0", VA = "0x1871A6FA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool DCBEHDNEFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x71A64A0", Offset = "0x71A54A0", VA = "0x1871A64A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool DHDGIHLOMBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x71A5F10", Offset = "0x71A4F10", VA = "0x1871A5F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public bool FMGAPBNGNOG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x71A5A90", Offset = "0x71A4A90", VA = "0x1871A5A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool HCBLINPELBF
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x71A5A30", Offset = "0x71A4A30", VA = "0x1871A5A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public bool DADEEKAKCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x71A5910", Offset = "0x71A4910", VA = "0x1871A5910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public bool EMKMIPLKGNN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x71A6220", Offset = "0x71A5220", VA = "0x1871A6220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool IHDFKNGPKBE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD11490", Offset = "0xD10490", VA = "0x180D11490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event CPDMFGNNCLB DIFELEDCGFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x71A5830", Offset = "0x71A4830", VA = "0x1871A5830")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x71A7450", Offset = "0x71A6450", VA = "0x1871A7450")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event DCOPMFBIBNC MKGJCFNPNBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x71A57C0", Offset = "0x71A47C0", VA = "0x1871A57C0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x71A73E0", Offset = "0x71A63E0", VA = "0x1871A73E0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event CPDMFGNNCLB LCHFLBDEBGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x71A5520", Offset = "0x71A4520", VA = "0x1871A5520")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x71A7140", Offset = "0x71A6140", VA = "0x1871A7140")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event CPDMFGNNCLB OFOJPGDJBLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x71A5590", Offset = "0x71A4590", VA = "0x1871A5590")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x71A71B0", Offset = "0x71A61B0", VA = "0x1871A71B0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event CPDMFGNNCLB FOLPMJHPPKI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x71A56E0", Offset = "0x71A46E0", VA = "0x1871A56E0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x71A7300", Offset = "0x71A6300", VA = "0x1871A7300")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<CDHDCBBOJLO, CDHDCBBOJLO> DAANECCDGFN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x71A5670", Offset = "0x71A4670", VA = "0x1871A5670")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x71A7290", Offset = "0x71A6290", VA = "0x1871A7290")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event CPDMFGNNCLB DHDGNPFFFNB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x71A5750", Offset = "0x71A4750", VA = "0x1871A5750")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x71A7370", Offset = "0x71A6370", VA = "0x1871A7370")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event CPDMFGNNCLB ECLOLMGEHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x71A58A0", Offset = "0x71A48A0", VA = "0x1871A58A0")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x71A74C0", Offset = "0x71A64C0", VA = "0x1871A74C0")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event CPDMFGNNCLB IAFBKCIIOGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x71A5600", Offset = "0x71A4600", VA = "0x1871A5600")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x71A7220", Offset = "0x71A6220", VA = "0x1871A7220")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x913240", Offset = "0x912240", VA = "0x180913240")]
		internal void OEBKICMCIEF(GKIJIJOABOO HBKAFCIHEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71A3F40", Offset = "0x71A2F40", VA = "0x1871A3F40")]
		internal void HEMALKBDMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71A5210", Offset = "0x71A4210", VA = "0x1871A5210")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		public void TestOverrideUnityRigidbody(Rigidbody CGIKJPPJJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x71A4ED0", Offset = "0x71A3ED0", VA = "0x1871A4ED0")]
		public void SetInertiaTensor((Quaternion rot, Vector3 moments) DKHOIHPOENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x71A39E0", Offset = "0x71A29E0", VA = "0x1871A39E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x71A3C90", Offset = "0x71A2C90", VA = "0x1871A3C90")]
		private GKIJIJOABOO PPJOJGKCOMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x71A3FD0", Offset = "0x71A2FD0", VA = "0x1871A3FD0")]
		private void HOCOANJGOKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x71A46C0", Offset = "0x71A36C0", VA = "0x1871A46C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
		public void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x71A3F40", Offset = "0x71A2F40", VA = "0x1871A3F40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x71A4660", Offset = "0x71A3660", VA = "0x1871A4660")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x71A4720", Offset = "0x71A3720", VA = "0x1871A4720")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x71A2FA0", Offset = "0x71A1FA0", VA = "0x1871A2FA0")]
		public void AddDoNotResetVelocityOnOwnershipChangeOverride(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x71A4790", Offset = "0x71A3790", VA = "0x1871A4790")]
		public void RemoveDoNotResetVelocityOnOwnershipChangeOverride(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x71A3C30", Offset = "0x71A2C30", VA = "0x1871A3C30")]
		public void DisableCachedInertialPropertyOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x71A4600", Offset = "0x71A3600", VA = "0x1871A4600")]
		public void MarkCachedInertialParametersDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x71A5030", Offset = "0x71A4030", VA = "0x1871A5030")]
		public void SetParent(RigidbodyEx CKDFGEALFAK, bool KPNOPNBLPDN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x71A4A90", Offset = "0x71A3A90", VA = "0x1871A4A90")]
		public void ResetLocalCenterOfMassToPrefabDefault()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x71A4360", Offset = "0x71A3360", VA = "0x1871A4360")]
		public bool IsRigidbodyAncestor(RigidbodyEx EJEBACBPAPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x71A4400", Offset = "0x71A3400", VA = "0x1871A4400")]
		public bool IsRigidbodyDescendant(RigidbodyEx AHBKPMBBPOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x71A3210", Offset = "0x71A2210", VA = "0x1871A3210")]
		public void AddInterpolationRestriction(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x71A4800", Offset = "0x71A3800", VA = "0x1871A4800")]
		public void RemoveInterpolationRestriction(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x71A3A50", Offset = "0x71A2A50", VA = "0x1871A3A50")]
		public IDisposable BeginKinematicScope()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x71A3280", Offset = "0x71A2280", VA = "0x1871A3280")]
		public void AddKinematic(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x71A4870", Offset = "0x71A3870", VA = "0x1871A4870")]
		public void RemoveKinematic(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x71A4FB0", Offset = "0x71A3FB0", VA = "0x1871A4FB0")]
		public void SetKinematic(object FFKJLIDBALM, bool JODHJMHBHKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x71A4DE0", Offset = "0x71A3DE0", VA = "0x1871A4DE0")]
		public void SetDiscontinuousPositionAndRotation(Vector3 GADCFFBMFPB, Quaternion OMAFNFIJLOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x71A4CF0", Offset = "0x71A3CF0", VA = "0x1871A4CF0")]
		public void SetDiscontinuousLocalPositionAndLocalRotation(Vector3 NHLFKICLGLO, Quaternion KDJHMFNDHML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x71A3E40", Offset = "0x71A2E40", VA = "0x1871A3E40")]
		public Vector3 GetConstrainedVelocity(Vector3 DIGLJLOIALF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x71A3D40", Offset = "0x71A2D40", VA = "0x1871A3D40")]
		public Vector3 GetConstrainedAngularVelocity(Vector3 BFOCKHBKDDG)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x71A3120", Offset = "0x71A2120", VA = "0x1871A3120")]
		public void AddForce(Vector3 HNGHLFFJCGK, ForceMode MJBIGEIBMGC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x71A3010", Offset = "0x71A2010", VA = "0x1871A3010")]
		public void AddForceAtPosition(Vector3 HNGHLFFJCGK, Vector3 NKMKMKDMOMJ, ForceMode MJBIGEIBMGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x71A3450", Offset = "0x71A2450", VA = "0x1871A3450")]
		public void AddTorque(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x71A32F0", Offset = "0x71A22F0", VA = "0x1871A32F0")]
		public void AddRelativeTorque(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x71A52F0", Offset = "0x71A42F0", VA = "0x1871A52F0")]
		public Vector3 WorldToLocalVelocity(Vector3 JIBAOMFGMOP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x71A4500", Offset = "0x71A3500", VA = "0x1871A4500")]
		public Vector3 LocalToWorldVelocity(Vector3 BEGLMLACECH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x71A3BD0", Offset = "0x71A2BD0", VA = "0x1871A3BD0")]
		public void ClearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x71A3B70", Offset = "0x71A2B70", VA = "0x1871A3B70")]
		public void ClearUnityRigidbodyVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x71A3B10", Offset = "0x71A2B10", VA = "0x1871A3B10")]
		public void ClearLinearVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x71A3AB0", Offset = "0x71A2AB0", VA = "0x1871A3AB0")]
		public void ClearAngularVelocity()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x71A4BF0", Offset = "0x71A3BF0", VA = "0x1871A4BF0")]
		public void ResetVelocityWorldSpace(Vector3 HKJCBCHFCPK, Vector3 IKOKBFBENAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x71A4AF0", Offset = "0x71A3AF0", VA = "0x1871A4AF0")]
		public void ResetVelocityLocalSpace(Vector3 HLEKEMPNOFO, Vector3 HALOBGHOELO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x71A49C0", Offset = "0x71A39C0", VA = "0x1871A49C0")]
		public void ResetLinearVelocityLocalSpace(Vector3 HLEKEMPNOFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x71A5120", Offset = "0x71A4120", VA = "0x1871A5120")]
		public bool SweepTest(Vector3 HCEFOMOBPKF, out RaycastHit CGLNBILMEGG, float FJDPGBJBEDI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x71A44A0", Offset = "0x71A34A0", VA = "0x1871A44A0")]
		public bool IsSleeping()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x71A50C0", Offset = "0x71A40C0", VA = "0x1871A50C0")]
		public void Sleep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x71A5290", Offset = "0x71A4290", VA = "0x1871A5290")]
		public void WakeUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x71A33E0", Offset = "0x71A23E0", VA = "0x1871A33E0")]
		public void AddShouldHaveUnityRigidbodyToken(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x71A48E0", Offset = "0x71A38E0", VA = "0x1871A48E0")]
		public void RemoveShouldHaveUnityRigidbodyToken(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x71A37D0", Offset = "0x71A27D0", VA = "0x1871A37D0")]
		public void ApplyForceVelocityChange(ICCDFEDDHBO PPEJEAKNDAO, Vector3 CINGCIOKEJN, float LOILAGEIMBB, float PBCAKBEJADJ = 8f, float KLJFGNKNFHH = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x71A36E0", Offset = "0x71A26E0", VA = "0x1871A36E0")]
		public void ApplyAngularVelocityChange(HKBPFCIHPDB AGONOFKHJKP, Vector3 MMCFJBKAPNO, float LPIFLMOBAEB = float.PositiveInfinity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x71A38E0", Offset = "0x71A28E0", VA = "0x1871A38E0")]
		[Obsolete]
		public void ApplyTorqueAngularVelocityChangeDeprecated(HKBPFCIHPDB AGONOFKHJKP, Vector3 NMKLOHCPMNL, float ABJOHFIBNNH = 7f, float LIPCNPEMHDI = 1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x71A3620", Offset = "0x71A2620", VA = "0x1871A3620")]
		public bool AllowedScaleChange(float JJMIOIPPABK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x71A3540", Offset = "0x71A2540", VA = "0x1871A3540")]
		public void AddWorldSpaceVelocityInHierarchyParentOverride(RigidbodyEx APBHIBICBMG, object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x71A4950", Offset = "0x71A3950", VA = "0x1871A4950")]
		public void RemoveWorldSpaceVelocityInHierarchyParentOverride(object FFKJLIDBALM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x71A5480", Offset = "0x71A4480", VA = "0x1871A5480")]
		public RigidbodyEx()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal static class ECFHMPBNOPJ
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D080", Offset = "0x5D1C080", VA = "0x185D1D080")]
	public static GKIJIJOABOO OGHMAKLGJOG(this RigidbodyEx HAPBMPEEKBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void CPDMFGNNCLB(RigidbodyEx PJPDIIDKAHN);
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EKBFGDHHPFO : JLAJANPMJBM
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int OIJDDAJNGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int IGMLPEJMDEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x91B190", Offset = "0x91A190", VA = "0x18091B190", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "6")]
	public CDHDCBBOJLO MOIHBHKFPDH(float JCGCOMMMLOD)
	{
		return default(CDHDCBBOJLO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
	public void AMLBOIMHPGF(ELBCOIDLJBC EOHGDDIECBJ, float MFIGFOJHONE, EAAMOAHJJCP IBCBBKNMCBK = EAAMOAHJJCP.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "8")]
	public void AMLBOIMHPGF(ELBCOIDLJBC EOHGDDIECBJ, Transform IKIJKLIBPKJ, float MFIGFOJHONE, EAAMOAHJJCP IBCBBKNMCBK = EAAMOAHJJCP.Off)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "9")]
	public void KFHJNPIOOAN(ELBCOIDLJBC EOHGDDIECBJ, [Optional] float? MFIGFOJHONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "10")]
	public void DNDEJFPIDIA(ELBCOIDLJBC APLLNPMBLDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "11")]
	public CDHDCBBOJLO LBDKKLEBDDO(ELBCOIDLJBC EOHGDDIECBJ)
	{
		return default(CDHDCBBOJLO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x85F430", Offset = "0x85E430", VA = "0x18085F430", Slot = "12")]
	public bool KCGLJKBEJCM(ELBCOIDLJBC EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "13")]
	public void IADJCOBAEBO(ELBCOIDLJBC EOHGDDIECBJ, EAAMOAHJJCP PPFNFAHPOGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public EKBFGDHHPFO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum AFHLDJNIIID
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	OnlyForReducedPhysicsRateAndNotParenting,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Never,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OnEvenWhenParenting
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public enum HKBPFCIHPDB
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct IMBADAJGPJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public Rigidbody JHKHONGEEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public PhotonView PKDKKABALLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public OverridableVector3 NIIFGFIFLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public OverridableVector3 CCMGHKCLEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public AFHLDJNIIID ACKBLPKDHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool DHPFBJKJNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool GAMJPLFENIG;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public delegate void DCOPMFBIBNC(RigidbodyEx PJPDIIDKAHN, bool KPNOPNBLPDN = false);
[Cpp2IlInjected.Token(Token = "0x200000E")]
[HCLCMACKFGM(typeof(DFMNIKJJGCA), new string[] { "Ignore", "Mock" })]
public class DOINAHAKEIM : DFMNIKJJGCA
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool IDMOHAOEILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9127F0", Offset = "0x9117F0", VA = "0x1809127F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
	public void AGAEBIJNOGA(string AOLOOCNDGPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "6")]
	public void PKIAGHFBACO(RigidbodyEx HAPBMPEEKBC, Action OKCPFPFJOFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8682E0", Offset = "0x8672E0", VA = "0x1808682E0", Slot = "7")]
	public JLAJANPMJBM HLOCOIGEKAP(int HGMMKECHGEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "8")]
	public void IMEOOKPPKOH(Vector3 NAOKAKLADHJ, float CKJKLOJOBPL, Color IFAEOGGHLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public DOINAHAKEIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[HCLCMACKFGM(typeof(JAKOFGLBKHL), new string[] { })]
public class DFGOPMJDCNB : JAKOFGLBKHL, ALCJCBIJLHN
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private CMKCAGGCPGO NNLEOFACMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private DFMNIKJJGCA IFMMICNCAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private KDBIAHFONJN HCIFEDKFADL;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool DPIFPHEOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5D1BA50", Offset = "0x5D1AA50", VA = "0x185D1BA50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public DFMNIKJJGCA EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KDBIAHFONJN PHOPMMJHKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BAA0", Offset = "0x5D1AAA0", VA = "0x185D1BAA0", Slot = "12")]
	public void InitReferences(CNIJJDNAGNG HFACFBNIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BC40", Offset = "0x5D1AC40", VA = "0x185D1BC40", Slot = "7")]
	public HKCCJJBDGFK KDACMKLJLNJ(RigidbodyEx HAPBMPEEKBC)
	{
		return default(HKCCJJBDGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BF30", Offset = "0x5D1AF30", VA = "0x185D1BF30")]
	private static HKCCJJBDGFK MMHAEHGDPMI(RigidbodyEx HAPBMPEEKBC)
	{
		return default(HKCCJJBDGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BB30", Offset = "0x5D1AB30", VA = "0x185D1BB30", Slot = "8")]
	public GKIJIJOABOO JEBPGNPPFJB(RigidbodyEx HAPBMPEEKBC, IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B980", Offset = "0x5D1A980", VA = "0x185D1B980", Slot = "11")]
	private RigidbodyEx CKMFCHCIKFJ(GameObject AMMCILJDEFM, IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C170", Offset = "0x5D1B170", VA = "0x185D1C170", Slot = "9")]
	public void NGFKPAIHAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C020", Offset = "0x5D1B020", VA = "0x185D1C020", Slot = "10")]
	public void NAIDENCELEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public DFGOPMJDCNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class MEFMBCKFDHK
{
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const float DGAFIOAMBJM = 0.001f;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const float NEOLECGNOEF = 0f;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const float IKEBPEBEDCH = 0.05f;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MEFMBCKFDHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class JBIAKNGGCPG
{
	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AE50", Offset = "0x5D29E50", VA = "0x185D2AE50")]
	public static void GGOCEPDIIHP(this Rigidbody CGIKJPPJJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AFA0", Offset = "0x5D29FA0", VA = "0x185D2AFA0")]
	public static void GGOCEPDIIHP(this Rigidbody CGIKJPPJJJL, Vector3 NFAFIOPFKFM, Quaternion LEBLIEFNHNJ, Vector3 ODAJEPEMELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1D274E0", Offset = "0x1D264E0", VA = "0x181D274E0")]
	public static void IAAMFFEFHLH(Vector3 DIGLJLOIALF, Vector3 CHHELNLAGNA, out Vector3 GEKBPPCAPHG, out Vector3 CBBBLDNOHMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum ICCDFEDDHBO
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Additive,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Override,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Reflective
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface IOJACBLDOHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool ACONAACMEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool DGEAHLNJGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CPDMFGNNCLB KJGCJBOEFOC;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECJGBFOOMFH();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GMEDKEJBENK(GKIJIJOABOO DJAGPEDCGHG);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EFFAAHLOMDP(GKIJIJOABOO DJAGPEDCGHG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface EOEFLBEIKKI
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	float DEGADDEAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	float IEHKIAHDHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPPEJFNNKOF(Rigidbody JHKHONGEEFO);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNOPBHJDCOE(Rigidbody JHKHONGEEFO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface DFMNIKJJGCA
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool IDMOHAOEILD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGAEBIJNOGA(string AOLOOCNDGPL);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PKIAGHFBACO(RigidbodyEx HAPBMPEEKBC, Action OKCPFPFJOFL);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JLAJANPMJBM HLOCOIGEKAP(int HGMMKECHGEI);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IMEOOKPPKOH(Vector3 NAOKAKLADHJ, float CKJKLOJOBPL, Color IFAEOGGHLKI);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface JAKOFGLBKHL
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	DFMNIKJJGCA EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	KDBIAHFONJN PHOPMMJHKLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool DPIFPHEOHNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HKCCJJBDGFK KDACMKLJLNJ(RigidbodyEx HAPBMPEEKBC);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GKIJIJOABOO JEBPGNPPFJB(RigidbodyEx HAPBMPEEKBC, IMBADAJGPJF HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NGFKPAIHAJA();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NAIDENCELEA();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	internal RigidbodyEx IIDIKNDIOCP(GameObject AMMCILJDEFM, [Optional] IMBADAJGPJF HHCEHFFEAKN);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface BBNLGKNKPJL
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnRootRBEXChanged(RigidbodyEx JNBHEEIOMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface EPGNOJDAMLC
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	Vector3 HBJLINEEDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	Vector3 HPLGGDFELMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBLFGKCHBNP(GKIJIJOABOO DJAGPEDCGHG, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGFDPLBGHAE(object FFKJLIDBALM);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal class DINDCEHJKDP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool GPPEICIHMBJ;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CEF0", Offset = "0x5D1BEF0", VA = "0x185D1CEF0")]
	public DINDCEHJKDP(JLDKEPCIJOL AOPJFEBAIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CE90", Offset = "0x5D1BE90", VA = "0x185D1CE90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JLDKEPCIJOL : GKIJIJOABOO, IDisposable, IMHHEPLLHBM
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const string CMDAPGNKNDC = "HasUnityRigidbodyByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	internal readonly JAKOFGLBKHL ALPIPCHDOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	internal HNNBMDLKLHB HCFNBNNCCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	internal PGHHFLOFLBF KFFLNCMOIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	internal IOJACBLDOHM FNBPOJMBJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	internal AKDKABCMEKE DIGLJLOIALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	internal EPGNOJDAMLC IHBPCFIADCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal IEOOEGFPLID GCHGIDBFMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal EOEFLBEIKKI PLJFEOOHLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal DNPNOKFCKLA JCHFMMNIFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	internal PKIFEAFNLDP EGOMDBDEMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal AALKHMIGOHM IPMAHPJHKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal COLFKEAIKIE HHMOCEMOOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal FCIFCFBJPFF HNGHLFFJCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal GFGHHLGFFPG GKECFLMHMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal NKPFENENCON JHKHONGEEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	internal KCLMAFFCLOC PCOIBCMFMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal IDisposable HCNGBDOLEFI;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public RigidbodyEx IDLGNFGLHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x90F2C0", Offset = "0x90E2C0", VA = "0x18090F2C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x90F0F0", Offset = "0x90E0F0", VA = "0x18090F0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public GameObject EBPNNJIDLIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA24A0", Offset = "0xAA14A0", VA = "0x180AA24A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xFF6490", Offset = "0xFF5490", VA = "0x180FF6490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public Transform CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D0E0", Offset = "0x5D2C0E0", VA = "0x185D2D0E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public IEnumerable<object> KGOEFBCIKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E950", Offset = "0x5D2D950", VA = "0x185D2E950", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F6B0", Offset = "0x5D2E6B0", VA = "0x185D2F6B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public GKIJIJOABOO HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E900", Offset = "0x5D2D900", VA = "0x185D2E900", Slot = "9")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5D30770", Offset = "0x5D2F770", VA = "0x185D30770", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public IReadOnlyList<GKIJIJOABOO> HCCPLAHGKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DB30", Offset = "0x5D2CB30", VA = "0x185D2DB30", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public GKIJIJOABOO LGIBJPCGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5D31160", Offset = "0x5D30160", VA = "0x185D31160", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool KHGGKLLFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D8E0", Offset = "0x5D2C8E0", VA = "0x185D2D8E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool ACONAACMEEO
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BCF0", Offset = "0x5D2ACF0", VA = "0x185D2BCF0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool DGEAHLNJGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BF10", Offset = "0x5D2AF10", VA = "0x185D2BF10", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public FBBNGPOGPDF GDMLIKAFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5D312E0", Offset = "0x5D302E0", VA = "0x185D312E0", Slot = "16")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FC60", Offset = "0x5D2EC60", VA = "0x185D2FC60", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public PCCGNALJHJC IEFFEBPICJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5D30FC0", Offset = "0x5D2FFC0", VA = "0x185D30FC0", Slot = "18")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DE80", Offset = "0x5D2CE80", VA = "0x185D2DE80", Slot = "19")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public float PBKPBDBPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5D31330", Offset = "0x5D30330", VA = "0x185D31330", Slot = "20")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5D30E70", Offset = "0x5D2FE70", VA = "0x185D30E70", Slot = "21")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Vector3 DBLBMIIKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D010", Offset = "0x5D2C010", VA = "0x185D2D010", Slot = "22")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F060", Offset = "0x5D2E060", VA = "0x185D2F060", Slot = "23")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector3 BHGOINLEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5D30930", Offset = "0x5D2F930", VA = "0x185D30930", Slot = "24")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CCC0", Offset = "0x5D2BCC0", VA = "0x185D2CCC0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Vector3 CJHFGNNEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F1E0", Offset = "0x5D2E1E0", VA = "0x185D2F1E0", Slot = "26")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CF40", Offset = "0x5D2BF40", VA = "0x185D2CF40", Slot = "27")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public Vector3 HCEGPGILCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E760", Offset = "0x5D2D760", VA = "0x185D2E760", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5D30CD0", Offset = "0x5D2FCD0", VA = "0x185D30CD0", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool FMGAPBNGNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C000", Offset = "0x5D2B000", VA = "0x185D2C000", Slot = "30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool HCBLINPELBF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FCC0", Offset = "0x5D2ECC0", VA = "0x185D2FCC0", Slot = "31")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool DADEEKAKCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C0F0", Offset = "0x5D2B0F0", VA = "0x185D2C0F0", Slot = "32")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool ICIMBBIGOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5D31C40", Offset = "0x5D30C40", VA = "0x185D31C40", Slot = "33")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector3 HBJLINEEDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5D31210", Offset = "0x5D30210", VA = "0x185D31210", Slot = "34")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 HPLGGDFELMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E150", Offset = "0x5D2D150", VA = "0x185D2E150", Slot = "35")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 MJJEDHDHCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CBF0", Offset = "0x5D2BBF0", VA = "0x185D2CBF0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5D30DA0", Offset = "0x5D2FDA0", VA = "0x185D30DA0", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 OMLCGNPLGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E830", Offset = "0x5D2D830", VA = "0x185D2E830", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public float CCHBEOPHGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DCE0", Offset = "0x5D2CCE0", VA = "0x185D2DCE0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public float HCPLDPOGKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F700", Offset = "0x5D2E700", VA = "0x185D2F700", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D880", Offset = "0x5D2C880", VA = "0x185D2D880", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public Vector3 ENGONBLHLID
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5D306A0", Offset = "0x5D2F6A0", VA = "0x185D306A0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Quaternion MGJBLPJDEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BBC0", Offset = "0x5D2ABC0", VA = "0x185D2BBC0", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public float DEGADDEAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F930", Offset = "0x5D2E930", VA = "0x185D2F930", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5D31380", Offset = "0x5D30380", VA = "0x185D31380", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public float IEHKIAHDHHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CEF0", Offset = "0x5D2BEF0", VA = "0x185D2CEF0", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E280", Offset = "0x5D2D280", VA = "0x185D2E280", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool JNEKBGLIJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E710", Offset = "0x5D2D710", VA = "0x185D2E710", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5D31DA0", Offset = "0x5D30DA0", VA = "0x185D31DA0", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public FMOMJHKLCHF HGMPDKIENND
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D6A0", Offset = "0x5D2C6A0", VA = "0x185D2D6A0", Slot = "51")]
		get
		{
			return default(FMOMJHKLCHF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BAB0", Offset = "0x5D2AAB0", VA = "0x185D2BAB0", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool HBNNMGOPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F550", Offset = "0x5D2E550", VA = "0x185D2F550", Slot = "53")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public Transform CPEPBHIJGJH
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DD30", Offset = "0x5D2CD30", VA = "0x185D2DD30", Slot = "54")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Transform ODCCNDECCIE
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DD30", Offset = "0x5D2CD30", VA = "0x185D2DD30", Slot = "55")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Vector3 OKHAADJKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CA20", Offset = "0x5D2BA20", VA = "0x185D2CA20", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D6F0", Offset = "0x5D2C6F0", VA = "0x185D2D6F0", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public float NODLEALDIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F750", Offset = "0x5D2E750", VA = "0x185D2F750", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FF80", Offset = "0x5D2EF80", VA = "0x185D2FF80", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public float EOEDBEBJIAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5D31630", Offset = "0x5D30630", VA = "0x185D31630", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x5D307D0", Offset = "0x5D2F7D0", VA = "0x185D307D0", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Quaternion IEIHNFGKHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F880", Offset = "0x5D2E880", VA = "0x185D2F880", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BF60", Offset = "0x5D2AF60", VA = "0x185D2BF60", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Vector3 MHKFHAGBNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D9A0", Offset = "0x5D2C9A0", VA = "0x185D2D9A0", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F3B0", Offset = "0x5D2E3B0", VA = "0x185D2F3B0", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Quaternion PPGNDJFMMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5D30660", Offset = "0x5D2F660", VA = "0x185D30660", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E240", Offset = "0x5D2D240", VA = "0x185D2E240", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public RigidbodyConstraints BHPHKBKMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BB70", Offset = "0x5D2AB70", VA = "0x185D2BB70", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CB90", Offset = "0x5D2BB90", VA = "0x185D2CB90", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public bool EKBGPCJPIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FEE0", Offset = "0x5D2EEE0", VA = "0x185D2FEE0", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5D2D940", Offset = "0x5D2C940", VA = "0x185D2D940", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public bool CJHHFDCHPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CAE0", Offset = "0x5D2BAE0", VA = "0x185D2CAE0", Slot = "132")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CollisionDetectionMode CFPICLDPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DD40", Offset = "0x5D2CD40", VA = "0x185D2DD40", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F650", Offset = "0x5D2E650", VA = "0x185D2F650", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public bool NIECADIBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E560", Offset = "0x5D2D560", VA = "0x185D2E560", Slot = "141")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public bool DHDGIHLOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5D30A60", Offset = "0x5D2FA60", VA = "0x185D30A60", Slot = "74")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public bool ODFCOAGIOJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F130", Offset = "0x5D2E130", VA = "0x185D2F130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool NMFPDCAKFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5D31770", Offset = "0x5D30770", VA = "0x185D31770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event CPDMFGNNCLB LCHFLBDEBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5D31710", Offset = "0x5D30710", VA = "0x185D31710", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BC90", Offset = "0x5D2AC90", VA = "0x185D2BC90", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event CPDMFGNNCLB OFOJPGDJBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FE20", Offset = "0x5D2EE20", VA = "0x185D2FE20", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5D311B0", Offset = "0x5D301B0", VA = "0x185D311B0", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event DCOPMFBIBNC GAJMBFEEBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5D30460", Offset = "0x5D2F460", VA = "0x185D30460", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E430", Offset = "0x5D2D430", VA = "0x185D2E430", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event CPDMFGNNCLB KJGCJBOEFOC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CB30", Offset = "0x5D2BB30", VA = "0x185D2CB30", Slot = "86")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F5F0", Offset = "0x5D2E5F0", VA = "0x185D2F5F0", Slot = "87")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event CPDMFGNNCLB FOLPMJHPPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5D31CF0", Offset = "0x5D30CF0", VA = "0x185D31CF0", Slot = "106")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E9A0", Offset = "0x5D2D9A0", VA = "0x185D2E9A0", Slot = "107")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event CPDMFGNNCLB AALLMMHBBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5D31650", Offset = "0x5D30650", VA = "0x185D31650", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F7C0", Offset = "0x5D2E7C0", VA = "0x185D2F7C0", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<CDHDCBBOJLO, CDHDCBBOJLO> DAANECCDGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5D31100", Offset = "0x5D30100", VA = "0x185D31100", Slot = "115")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5D316B0", Offset = "0x5D306B0", VA = "0x185D316B0", Slot = "116")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event CPDMFGNNCLB JBJICGHHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E6B0", Offset = "0x5D2D6B0", VA = "0x185D2E6B0", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F4F0", Offset = "0x5D2E4F0", VA = "0x185D2F4F0", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event CPDMFGNNCLB IAFBKCIIOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C050", Offset = "0x5D2B050", VA = "0x185D2C050", Slot = "123")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2DA90", Offset = "0x5D2CA90", VA = "0x185D2DA90", Slot = "124")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D31ED0", Offset = "0x5D30ED0", VA = "0x185D31ED0")]
	public JLDKEPCIJOL(GameObject LAPEIFCGFLM, RigidbodyEx OJGIKIHBCKE, JAKOFGLBKHL ALPIPCHDOEM, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D31820", Offset = "0x5D30820", VA = "0x185D31820", Slot = "142")]
	protected virtual void PFHMHDJMFKF(JAKOFGLBKHL ALPIPCHDOEM, IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D170", Offset = "0x5D2C170", VA = "0x185D2D170", Slot = "143")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D560", Offset = "0x5D2C560", VA = "0x185D2D560", Slot = "75")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CEA0", Offset = "0x5D2BEA0", VA = "0x185D2CEA0", Slot = "76")]
	public void DCMCMHNNGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E220", Offset = "0x5D2D220", VA = "0x185D2E220", Slot = "77")]
	public void GEPBLOKJEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FBB0", Offset = "0x5D2EBB0", VA = "0x185D2FBB0")]
	private void KMECDBNKAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5D317B0", Offset = "0x5D307B0", VA = "0x185D317B0", Slot = "85")]
	public void PELENMOAPPI(GKIJIJOABOO CKDFGEALFAK, bool KPNOPNBLPDN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CD90", Offset = "0x5D2BD90", VA = "0x185D2CD90", Slot = "88")]
	public void CPPMPAIBAIE(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FE80", Offset = "0x5D2EE80", VA = "0x185D2FE80", Slot = "89")]
	public void LGIPNJNGKEK(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5D304C0", Offset = "0x5D2F4C0", VA = "0x185D304C0", Slot = "90")]
	public Vector3 MBJCIOAOPLA(Vector3 JIBAOMFGMOP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F400", Offset = "0x5D2E400", VA = "0x185D2F400", Slot = "91")]
	public Vector3 IPGPGFJKEGH(Vector3 BEGLMLACECH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CEA0", Offset = "0x5D2BEA0", VA = "0x185D2CEA0", Slot = "92")]
	public void OBOCHBKOAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DC90", Offset = "0x5D2CC90", VA = "0x185D2DC90", Slot = "93")]
	public void FJIMPNLFGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5D308E0", Offset = "0x5D2F8E0", VA = "0x185D308E0", Slot = "94")]
	public void MLMACKBHHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C8D0", Offset = "0x5D2B8D0", VA = "0x185D2C8D0", Slot = "95")]
	public void CIJCEOHOIFH(Vector3 HKJCBCHFCPK, Vector3 IKOKBFBENAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5D30ED0", Offset = "0x5D2FED0", VA = "0x185D30ED0", Slot = "96")]
	public void NNONEIIDODB(Vector3 HLEKEMPNOFO, Vector3 HALOBGHOELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E490", Offset = "0x5D2D490", VA = "0x185D2E490", Slot = "97")]
	public void GNHFMHHHPJP(Vector3 GLHHKKHDPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DB80", Offset = "0x5D2CB80", VA = "0x185D2DB80", Slot = "98")]
	public void FHIGAJBINGD(ICCDFEDDHBO PPEJEAKNDAO, Vector3 CINGCIOKEJN, float LOILAGEIMBB, float PBCAKBEJADJ = 8f, float KLJFGNKNFHH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x5D31010", Offset = "0x5D30010", VA = "0x185D31010", Slot = "99")]
	public void NPMAPGEAPOM(HKBPFCIHPDB AGONOFKHJKP, Vector3 MMCFJBKAPNO, float LPIFLMOBAEB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FD20", Offset = "0x5D2ED20", VA = "0x185D2FD20", Slot = "100")]
	[Obsolete]
	public void LCMNPPLAMEK(HKBPFCIHPDB AGONOFKHJKP, Vector3 NMKLOHCPMNL, float ABJOHFIBNNH = 7f, float LIPCNPEMHDI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BD40", Offset = "0x5D2AD40", VA = "0x185D2BD40", Slot = "101")]
	public Vector3 BABHBPECAMD(Vector3 CKDFGEALFAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C630", Offset = "0x5D2B630", VA = "0x185D2C630", Slot = "102")]
	public Vector3 BPDJEMCGEHA(Vector3 CKDFGEALFAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F770", Offset = "0x5D2E770", VA = "0x185D2F770", Slot = "103")]
	public void JOICJIPFNHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EA00", Offset = "0x5D2DA00", VA = "0x185D2EA00", Slot = "104")]
	public void HGGLKPKKAAI(GKIJIJOABOO APBHIBICBMG, object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C9C0", Offset = "0x5D2B9C0", VA = "0x185D2C9C0", Slot = "105")]
	public void CJJOPIHMMFK(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5D30BF0", Offset = "0x5D2FBF0", VA = "0x185D30BF0", Slot = "44")]
	public void NANHMOGKJKJ((Quaternion rot, Vector3 moments) DKHOIHPOENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5D30610", Offset = "0x5D2F610", VA = "0x185D30610", Slot = "108")]
	public void MIGNLHGCABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DDE0", Offset = "0x5D2CDE0", VA = "0x185D2DDE0", Slot = "109")]
	public void FPKLGKNCPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FF30", Offset = "0x5D2EF30", VA = "0x185D2FF30", Slot = "110")]
	public void LGLOKNEEAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C5E0", Offset = "0x5D2B5E0", VA = "0x185D2C5E0", Slot = "113")]
	public bool BOKGHGDFDOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F5A0", Offset = "0x5D2E5A0", VA = "0x185D2F5A0", Slot = "78")]
	public void JCCAKBLBCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DD90", Offset = "0x5D2CD90", VA = "0x185D2DD90", Slot = "114")]
	public void FMOBJOLKMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DE30", Offset = "0x5D2CE30", VA = "0x185D2DE30", Slot = "119")]
	public IDisposable GACBMNJIACD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F820", Offset = "0x5D2E820", VA = "0x185D2F820", Slot = "120")]
	public void KAELNCJCGFP(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F000", Offset = "0x5D2E000", VA = "0x185D2F000", Slot = "121")]
	public void HOCNFCJLBPG(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E2E0", Offset = "0x5D2D2E0", VA = "0x185D2E2E0", Slot = "122")]
	public void GKJKMFOOEAJ(object FFKJLIDBALM, bool JODHJMHBHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DEE0", Offset = "0x5D2CEE0", VA = "0x185D2DEE0", Slot = "125")]
	public void GEDPKOALOFN(Vector3 GADCFFBMFPB, Quaternion OMAFNFIJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C720", Offset = "0x5D2B720", VA = "0x185D2C720", Slot = "126")]
	public void CEBEBAGHPBA(Vector3 NHLFKICLGLO, Quaternion KDJHMFNDHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x5D31B00", Offset = "0x5D30B00", VA = "0x185D31B00", Slot = "127")]
	public bool PGHGAILNCBG(float JJMIOIPPABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5D305B0", Offset = "0x5D2F5B0", VA = "0x185D305B0", Slot = "128")]
	public void MGKFGHOJPBF(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5D313E0", Offset = "0x5D303E0", VA = "0x185D313E0", Slot = "129")]
	public void OLJBIHPBAAM(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5D31C90", Offset = "0x5D30C90", VA = "0x185D31C90", Slot = "130")]
	public void PKCJDHEHHKF(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5D30A00", Offset = "0x5D2FA00", VA = "0x185D30A00", Slot = "131")]
	public void MNPDLAIMCKF(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D9F0", Offset = "0x5D2C9F0", VA = "0x185D2D9F0")]
	public void EMGNNEOCFOJ(object FFKJLIDBALM, bool CAMKFIDILHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5D31B60", Offset = "0x5D30B60", VA = "0x185D31B60", Slot = "133")]
	public void PJCLLEGFFHE(Vector3 HNGHLFFJCGK, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EDC0", Offset = "0x5D2DDC0", VA = "0x185D2EDC0", Slot = "134")]
	public void HJJLBECNANN(Vector3 HNGHLFFJCGK, Vector3 NKMKMKDMOMJ, ForceMode MJBIGEIBMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FFF0", Offset = "0x5D2EFF0", VA = "0x185D2FFF0", Slot = "135")]
	public void LMJMOPPPAJB(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BE30", Offset = "0x5D2AE30", VA = "0x185D2BE30", Slot = "136")]
	public void BBEKPKFIJJP(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F980", Offset = "0x5D2E980", VA = "0x185D2F980", Slot = "137")]
	public bool KDILDFBMPIF(Vector3 HCEFOMOBPKF, out RaycastHit CGLNBILMEGG, float FJDPGBJBEDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5D31D50", Offset = "0x5D30D50", VA = "0x185D31D50", Slot = "138")]
	public void PMMIPEBHDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5D31E90", Offset = "0x5D30E90", VA = "0x185D31E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FB20", Offset = "0x5D2EB20", VA = "0x185D2FB20")]
	private void KKGPEANBKJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D240", Offset = "0x5D2C240", VA = "0x185D2D240")]
	private void EAICKLHLFCJ(GKIJIJOABOO DJAGPEDCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5D31440", Offset = "0x5D30440", VA = "0x185D31440")]
	private void OLMKKDLLFLA(GKIJIJOABOO DJAGPEDCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5D2FA70", Offset = "0x5D2EA70", VA = "0x185D2FA70")]
	private void KJCBNMOAFKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F2B0", Offset = "0x5D2E2B0", VA = "0x185D2F2B0")]
	private void IIGDDEPBHLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CDF0", Offset = "0x5D2BDF0", VA = "0x185D2CDF0")]
	private void DBPFOEPPCIF(GKIJIJOABOO BPJPHGOLFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E350", Offset = "0x5D2D350", VA = "0x185D2E350")]
	private void GMEDKEJBENK(GKIJIJOABOO DJAGPEDCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D7A0", Offset = "0x5D2C7A0", VA = "0x185D2D7A0")]
	private void EFFAAHLOMDP(GKIJIJOABOO DJAGPEDCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D3F0", Offset = "0x5D2C3F0", VA = "0x185D2D3F0")]
	private void ECFIHJKMLJF(RigidbodyEx DJAGPEDCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5D300D0", Offset = "0x5D2F0D0", VA = "0x185D300D0", Slot = "144")]
	protected virtual void LPLNMBKILNL(RigidbodyEx HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EED0", Offset = "0x5D2DED0", VA = "0x185D2EED0")]
	[Conditional("UNITY_EDITOR")]
	private void HLLANHMAJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EAC0", Offset = "0x5D2DAC0", VA = "0x185D2EAC0")]
	protected void HHDJJBMMGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C1E0", Offset = "0x5D2B1E0", VA = "0x185D2C1E0")]
	protected void BOFMJBIOMIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5D31E00", Offset = "0x5D30E00", VA = "0x185D31E00", Slot = "145")]
	protected virtual IDisposable PPEIEDAFEAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal static class MDGENHGCDJG
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x719CAF0", Offset = "0x719BAF0", VA = "0x18719CAF0")]
	public static GKIJIJOABOO KBONLDCGBCF(this GKIJIJOABOO HAPBMPEEKBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x719C9B0", Offset = "0x719B9B0", VA = "0x18719C9B0")]
	public static bool HEBHKKPBGKH(this GKIJIJOABOO HAPBMPEEKBC, GKIJIJOABOO EJEBACBPAPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x719CBB0", Offset = "0x719BBB0", VA = "0x18719CBB0")]
	public static bool LLPBBIJIMDB(this GKIJIJOABOO HAPBMPEEKBC, GKIJIJOABOO AHBKPMBBPOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x719CA30", Offset = "0x719BA30", VA = "0x18719CA30")]
	public static RigidbodyEx IDLGNFGLHMJ(this GKIJIJOABOO OGHMAKLGJOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x719CA80", Offset = "0x719BA80", VA = "0x18719CA80")]
	public static JLDKEPCIJOL JMGKEBAEGAF(this GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface IEOOEGFPLID
{
	[Cpp2IlInjected.Token(Token = "0x17000076")]
	Vector3 MJJEDHDHCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	Vector3 OMLCGNPLGJE
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	float CCHBEOPHGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	float HCPLDPOGKKL
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	Vector3 ENGONBLHLID
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	Quaternion MGJBLPJDEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	event CPDMFGNNCLB HNJACDDFBNH;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NANHMOGKJKJ((Quaternion rot, Vector3 moments) DKHOIHPOENC);

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void FPKLGKNCPLO();

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void MIGNLHGCABH();

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void LGLOKNEEAMG();

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JPPEJFNNKOF(Rigidbody JHKHONGEEFO);

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LNOPBHJDCOE(Rigidbody JHKHONGEEFO);

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PMMIPEBHDKH();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface IMHHEPLLHBM
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	bool NIECADIBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface GKIJIJOABOO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	RigidbodyEx IDLGNFGLHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	GameObject EBPNNJIDLIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	Transform CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IEnumerable<object> KGOEFBCIKDO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	GKIJIJOABOO HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	IReadOnlyList<GKIJIJOABOO> HCCPLAHGKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	GKIJIJOABOO LGIBJPCGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	bool KHGGKLLFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	bool ACONAACMEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool DGEAHLNJGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	FBBNGPOGPDF GDMLIKAFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	PCCGNALJHJC IEFFEBPICJN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	float PBKPBDBPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	Vector3 DBLBMIIKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	Vector3 BHGOINLEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	Vector3 CJHFGNNEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	Vector3 HCEGPGILCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	bool FMGAPBNGNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	bool HCBLINPELBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	bool DADEEKAKCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	bool ICIMBBIGOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	Vector3 HBJLINEEDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	Vector3 HPLGGDFELMA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	Vector3 MJJEDHDHCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(Slot = "33")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	Vector3 OMLCGNPLGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(Slot = "34")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	float CCHBEOPHGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "35")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	float HCPLDPOGKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(Slot = "37")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	Vector3 ENGONBLHLID
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "38")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	Quaternion MGJBLPJDEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	float DEGADDEAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(Slot = "42")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	float IEHKIAHDHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(Slot = "44")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	bool JNEKBGLIJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(Slot = "45")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(Slot = "46")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	FMOMJHKLCHF HGMPDKIENND
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(Slot = "47")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(Slot = "48")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool HBNNMGOPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	Transform CPEPBHIJGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	Transform ODCCNDECCIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	Vector3 OKHAADJKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "53")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	float NODLEALDIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "54")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "55")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	float EOEDBEBJIAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "57")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	Quaternion IEIHNFGKHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "59")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	Vector3 MHKFHAGBNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "61")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	Quaternion PPGNDJFMMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "62")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "63")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	RigidbodyConstraints BHPHKBKMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "64")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "65")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	bool EKBGPCJPIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "67")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	CollisionDetectionMode CFPICLDPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "68")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "69")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	bool DHDGIHLOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	bool CJHHFDCHPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "128")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	event CPDMFGNNCLB LCHFLBDEBGA;

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	event CPDMFGNNCLB OFOJPGDJBLH;

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	event DCOPMFBIBNC GAJMBFEEBCI;

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	event CPDMFGNNCLB KJGCJBOEFOC;

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	event CPDMFGNNCLB FOLPMJHPPKI;

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	event CPDMFGNNCLB AALLMMHBBEK;

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	event Action<CDHDCBBOJLO, CDHDCBBOJLO> DAANECCDGFN;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	event CPDMFGNNCLB JBJICGHHDEB;

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	event CPDMFGNNCLB IAFBKCIIOGJ;

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void NANHMOGKJKJ((Quaternion rot, Vector3 moments) DKHOIHPOENC);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void ECJGBFOOMFH();

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void DCMCMHNNGHL();

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void GEPBLOKJEFN();

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void JCCAKBLBCOJ();

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(Slot = "81")]
	void PELENMOAPPI(GKIJIJOABOO CKDFGEALFAK, bool KPNOPNBLPDN = false);

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void CPPMPAIBAIE(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void LGIPNJNGKEK(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(Slot = "86")]
	Vector3 MBJCIOAOPLA(Vector3 JIBAOMFGMOP);

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(Slot = "87")]
	Vector3 IPGPGFJKEGH(Vector3 BEGLMLACECH);

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "88")]
	void OBOCHBKOAMG();

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(Slot = "89")]
	void FJIMPNLFGOE();

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(Slot = "90")]
	void MLMACKBHHDN();

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(Slot = "91")]
	void CIJCEOHOIFH(Vector3 HKJCBCHFCPK, Vector3 IKOKBFBENAE);

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(Slot = "92")]
	void NNONEIIDODB(Vector3 HLEKEMPNOFO, Vector3 HALOBGHOELO);

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(Slot = "93")]
	void GNHFMHHHPJP(Vector3 GLHHKKHDPIN);

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(Slot = "94")]
	void FHIGAJBINGD(ICCDFEDDHBO PPEJEAKNDAO, Vector3 CINGCIOKEJN, float LOILAGEIMBB, float PBCAKBEJADJ = 8f, float KLJFGNKNFHH = 1f);

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(Slot = "95")]
	void NPMAPGEAPOM(HKBPFCIHPDB AGONOFKHJKP, Vector3 MMCFJBKAPNO, float LPIFLMOBAEB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "96")]
	void LCMNPPLAMEK(HKBPFCIHPDB AGONOFKHJKP, Vector3 NMKLOHCPMNL, float ABJOHFIBNNH = 7f, float LIPCNPEMHDI = 1f);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "97")]
	Vector3 BABHBPECAMD(Vector3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(Slot = "98")]
	Vector3 BPDJEMCGEHA(Vector3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "99")]
	void JOICJIPFNHP();

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "100")]
	void HGGLKPKKAAI(GKIJIJOABOO APBHIBICBMG, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(Slot = "101")]
	void CJJOPIHMMFK(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(Slot = "104")]
	void MIGNLHGCABH();

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "105")]
	void FPKLGKNCPLO();

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "106")]
	void LGLOKNEEAMG();

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "109")]
	bool BOKGHGDFDOI();

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "110")]
	void FMOBJOLKMGD();

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "115")]
	IDisposable GACBMNJIACD();

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "116")]
	void KAELNCJCGFP(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "117")]
	void HOCNFCJLBPG(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "118")]
	void GKJKMFOOEAJ(object FFKJLIDBALM, bool JODHJMHBHKG);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "121")]
	void GEDPKOALOFN(Vector3 GADCFFBMFPB, Quaternion OMAFNFIJLOG);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "122")]
	void CEBEBAGHPBA(Vector3 NHLFKICLGLO, Quaternion KDJHMFNDHML);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "123")]
	bool PGHGAILNCBG(float JJMIOIPPABK);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "124")]
	void MGKFGHOJPBF(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "125")]
	void OLJBIHPBAAM(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "126")]
	void PKCJDHEHHKF(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "127")]
	void MNPDLAIMCKF(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "129")]
	void PJCLLEGFFHE(Vector3 HNGHLFFJCGK, ForceMode MJBIGEIBMGC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "130")]
	void HJJLBECNANN(Vector3 HNGHLFFJCGK, Vector3 NKMKMKDMOMJ, ForceMode MJBIGEIBMGC);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "131")]
	void LMJMOPPPAJB(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "132")]
	void BBEKPKFIJJP(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "133")]
	bool KDILDFBMPIF(Vector3 HCEFOMOBPKF, out RaycastHit CGLNBILMEGG, float FJDPGBJBEDI);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "134")]
	void PMMIPEBHDKH();

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "135")]
	new string ToString();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FCIFCFBJPFF
{
	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJCLLEGFFHE(Vector3 HNGHLFFJCGK, ForceMode MJBIGEIBMGC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HJJLBECNANN(Vector3 HNGHLFFJCGK, Vector3 NKMKMKDMOMJ, ForceMode MJBIGEIBMGC);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMJMOPPPAJB(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBEKPKFIJJP(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force);
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FBBNGPOGPDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Vector3 NCJNHHNFGBI();

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 PIFCIBMMDHL();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PGHHFLOFLBF
{
	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	bool ADLCDDONGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	FLACBGLBMKA CKAGLECBIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECJGBFOOMFH();

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNEHOALDMKJ(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CHDOAHKLOJM(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HCBFOLLPIFP(GKIJIJOABOO HAPBMPEEKBC);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NMLFHJHIDFH(GKIJIJOABOO HAPBMPEEKBC);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BCFHKCJHAAI();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface AALKHMIGOHM : IDisposable, ELBCOIDLJBC
{
	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	FMOMJHKLCHF HGMPDKIENND
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	event Action<CDHDCBBOJLO, CDHDCBBOJLO> DAANECCDGFN;

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECJGBFOOMFH();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HNNBMDLKLHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	IReadOnlyList<GKIJIJOABOO> HCCPLAHGKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	GKIJIJOABOO LGIBJPCGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	GKIJIJOABOO HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	event CPDMFGNNCLB LCHFLBDEBGA;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	event CPDMFGNNCLB OFOJPGDJBLH;

	[Cpp2IlInjected.Token(Token = "0x14000021")]
	event DCOPMFBIBNC GAJMBFEEBCI;

	[Cpp2IlInjected.Token(Token = "0x14000022")]
	event Action JDHEPKFGNNG;

	[Cpp2IlInjected.Token(Token = "0x14000023")]
	event Action HHMCDAKEEHN;

	[Cpp2IlInjected.Token(Token = "0x14000024")]
	event Action<GKIJIJOABOO> AMMFMNEEOGM;

	[Cpp2IlInjected.Token(Token = "0x14000025")]
	event Action<GKIJIJOABOO> NKLGELOFNCG;

	[Cpp2IlInjected.Token(Token = "0x14000026")]
	event Action MNMELFCLPCA;

	[Cpp2IlInjected.Token(Token = "0x14000027")]
	event Action<GKIJIJOABOO> CEGKOKMJALM;

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void PELENMOAPPI(GKIJIJOABOO GFJHNOHABFL, bool KPNOPNBLPDN = false);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface KDBIAHFONJN
{
	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNNBMDLKLHB OGBHICJOKHL(GKIJIJOABOO HBKAFCIHEAM);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AKDKABCMEKE NANJCOFPMIJ(GKIJIJOABOO HBKAFCIHEAM);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EPGNOJDAMLC NJEEJAHAMHC(GKIJIJOABOO HBKAFCIHEAM);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EOEFLBEIKKI LCGLDAEIICG(GKIJIJOABOO HBKAFCIHEAM);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PKIFEAFNLDP LDIKLAKHKJI(GKIJIJOABOO HBKAFCIHEAM);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AALKHMIGOHM LKNBBLKOCDK(GKIJIJOABOO HBKAFCIHEAM);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "6")]
	COLFKEAIKIE DJBBMFHFDGM(GKIJIJOABOO HBKAFCIHEAM);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "7")]
	FCIFCFBJPFF BOCAPHJPMGD(GKIJIJOABOO HBKAFCIHEAM);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KCLMAFFCLOC FHOHPFBKKPC(GKIJIJOABOO HBKAFCIHEAM);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "9")]
	DNPNOKFCKLA CDHFFHIJPAO(GKIJIJOABOO HBKAFCIHEAM);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NKPFENENCON GPLNLPNFGLB(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IOJACBLDOHM BGLAILFIDDF(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PGHHFLOFLBF FJGPAKPMDJL(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IEOOEGFPLID MHDNBLBJAIO(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "14")]
	GFGHHLGFFPG GDIPABKDHBG(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	GKIJIJOABOO JEBPGNPPFJB(RigidbodyEx HAPBMPEEKBC, IMBADAJGPJF HHCEHFFEAKN, JAKOFGLBKHL ALPIPCHDOEM);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface GFGHHLGFFPG
{
	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	bool EKBGPCJPIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	bool NLFPLPANICC
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	RigidbodyConstraints BHPHKBKMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPPEJFNNKOF(Rigidbody JHKHONGEEFO);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LNOPBHJDCOE(Rigidbody JHKHONGEEFO);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface PCCGNALJHJC
{
	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NBIHIPICMBP(Vector3 AANGENGFAPJ);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IABEFBMKNFC(Vector3 BFOCKHBKDDG);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LIIPIJJAJGL(Vector3 AANGENGFAPJ);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HCLELKJFNJE(Vector3 BFOCKHBKDDG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface COLFKEAIKIE
{
	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	bool HBNNMGOPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	IEnumerable<object> NKMCCLFKAIP
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000028")]
	event CPDMFGNNCLB JBJICGHHDEB;

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IPKMBAHFCID();

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KAELNCJCGFP(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOCNFCJLBPG(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GKJKMFOOEAJ(object FFKJLIDBALM, bool JODHJMHBHKG);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IDisposable GACBMNJIACD();

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JPPEJFNNKOF(Rigidbody CIEJBNMPJKE);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LNOPBHJDCOE(Rigidbody JHKHONGEEFO);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface KCLMAFFCLOC
{
	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	CollisionDetectionMode CFPICLDPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECJGBFOOMFH();

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HMCOBLAMCNB(bool DCBEHDNEFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OKAEEFDELAJ(bool DCBEHDNEFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JPPEJFNNKOF(Rigidbody JHKHONGEEFO);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KDILDFBMPIF(Vector3 HCEFOMOBPKF, out RaycastHit CGLNBILMEGG, float FJDPGBJBEDI);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface AKDKABCMEKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	FBBNGPOGPDF GDMLIKAFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	PCCGNALJHJC IEFFEBPICJN
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	Vector3 CJHFGNNEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	Vector3 DBLBMIIKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	Vector3 HCEGPGILCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	Vector3 BHGOINLEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	float PBKPBDBPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	bool ICIMBBIGOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void ECJGBFOOMFH();

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JCHDKKLHDLC(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NPMAPGEAPOM(HKBPFCIHPDB AGONOFKHJKP, Vector3 MMCFJBKAPNO, float LPIFLMOBAEB = float.PositiveInfinity);

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FHIGAJBINGD(ICCDFEDDHBO PPEJEAKNDAO, Vector3 CINGCIOKEJN, float LOILAGEIMBB, float PBCAKBEJADJ = 8f, float KLJFGNKNFHH = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void LCMNPPLAMEK(HKBPFCIHPDB AGONOFKHJKP, Vector3 NMKLOHCPMNL, float ABJOHFIBNNH = 7f, float LIPCNPEMHDI = 1f);

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void MLMACKBHHDN();

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void FJIMPNLFGOE();

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void JOICJIPFNHP();

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void OBOCHBKOAMG();

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JPPEJFNNKOF(Rigidbody JHKHONGEEFO);

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 BPDJEMCGEHA(Vector3 BFOCKHBKDDG);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 BABHBPECAMD(Vector3 DIGLJLOIALF);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void LOJJDJMIBDL(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void GNHFMHHHPJP(Vector3 GLHHKKHDPIN);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void NNONEIIDODB(Vector3 HLEKEMPNOFO, Vector3 HALOBGHOELO);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void CIJCEOHOIFH(Vector3 HKJCBCHFCPK, Vector3 IKOKBFBENAE);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Vector3 IPGPGFJKEGH(Vector3 BEGLMLACECH);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Vector3 MBJCIOAOPLA(Vector3 JIBAOMFGMOP);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface NKPFENENCON
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	bool CJHHFDCHPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ECJGBFOOMFH();

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PKCJDHEHHKF(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MNPDLAIMCKF(object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GBLJPONPLOL();

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FFCBJIOHPMF();

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ALFOHLKNOEN();

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NABHAJFKIMF();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface DNPNOKFCKLA
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	bool JNEKBGLIJCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JPPEJFNNKOF(Rigidbody JHKHONGEEFO);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LNOPBHJDCOE(Rigidbody JHKHONGEEFO);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PKIFEAFNLDP
{
	[Cpp2IlInjected.Token(Token = "0x14000029")]
	event CPDMFGNNCLB AALLMMHBBEK;

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECJGBFOOMFH();

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BOKGHGDFDOI();

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PMKDOCIKNCM();

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JCCAKBLBCOJ();

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GEEAFJLCCHL();

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FMOBJOLKMGD();

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ADKDLIBNMCE(bool FGLGAHABBBB);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[HCLCMACKFGM(typeof(JLFGDFIPKNO), new string[] { })]
public sealed class OCLANDBIBDO : ALCJCBIJLHN, JLFGDFIPKNO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[AJHKPBPNKHI]
	private HIOAPONHMCI HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool GPPEICIHMBJ;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool EDGMLIFNIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x85F3D0", Offset = "0x85E3D0", VA = "0x18085F3D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x719E860", Offset = "0x719D860", VA = "0x18719E860", Slot = "4")]
	public void InitReferences(CNIJJDNAGNG HFACFBNIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x719E700", Offset = "0x719D700", VA = "0x18719E700", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x719EC00", Offset = "0x719DC00", VA = "0x18719EC00", Slot = "6")]
	public void OLCKFEJDPHL(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x719E8B0", Offset = "0x719D8B0", VA = "0x18719E8B0", Slot = "7")]
	public void NLOLDIMNGNF(HKCCJJBDGFK GCCJEBKFANJ, bool CEKHLGEIGKA, bool ICPAGGGLIAI, bool PKBHDOPFEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x719E730", Offset = "0x719D730", VA = "0x18719E730")]
	private bool IPCPBGMDLLG(HKCCJJBDGFK GCCJEBKFANJ, out PICOGHEPFKI HBKAFCIHEAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x719EAA0", Offset = "0x719DAA0", VA = "0x18719EAA0")]
	private bool OAPHNPBHIOM(HKCCJJBDGFK GCCJEBKFANJ, out KHAFEMOENIA AJMGMJECILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x719E5A0", Offset = "0x719D5A0", VA = "0x18719E5A0")]
	private bool ACJKBHFIDHJ(HKCCJJBDGFK GCCJEBKFANJ, out KHHCOJHIJMK DDEAIONKBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public OCLANDBIBDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal sealed class KHHCOJHIJMK : FDNGLPDCKHB, IEOOEGFPLID
{
	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	[Obsolete]
	public Vector3 MJJEDHDHCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x5D35260", Offset = "0x5D34260", VA = "0x185D35260", Slot = "6")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D35380", Offset = "0x5D34380", VA = "0x185D35380", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public Vector3 HEOFIJIAMLD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D36C20", Offset = "0x5D35C20", VA = "0x185D36C20")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D35380", Offset = "0x5D34380", VA = "0x185D35380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public Vector3 JGLIAMHENCB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D35090", Offset = "0x5D34090", VA = "0x185D35090")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	[Obsolete]
	public Vector3 OMLCGNPLGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D359F0", Offset = "0x5D349F0", VA = "0x185D359F0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	[Obsolete]
	public float CCHBEOPHGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D354B0", Offset = "0x5D344B0", VA = "0x185D354B0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public float AFCKFHMMOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D35C30", Offset = "0x5D34C30", VA = "0x185D35C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public float HCPLDPOGKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D35F50", Offset = "0x5D34F50", VA = "0x185D35F50", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D353B0", Offset = "0x5D343B0", VA = "0x185D353B0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public Vector3 ENGONBLHLID
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D368B0", Offset = "0x5D358B0", VA = "0x185D368B0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	public Quaternion MGJBLPJDEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5D34DB0", Offset = "0x5D33DB0", VA = "0x185D34DB0", Slot = "13")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x5D19E60", Offset = "0x5D18E60", VA = "0x185D19E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002A")]
	public event CPDMFGNNCLB HNJACDDFBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5D36230", Offset = "0x5D35230", VA = "0x185D36230", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5D351C0", Offset = "0x5D341C0", VA = "0x185D351C0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D38770", Offset = "0x5D37770", VA = "0x185D38770")]
	public KHHCOJHIJMK(GKIJIJOABOO HAPBMPEEKBC, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5D35B70", Offset = "0x5D34B70", VA = "0x185D35B70")]
	public float3 IIEILBEEEEF()
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D37F20", Offset = "0x5D36F20", VA = "0x185D37F20")]
	public bool ONCFJOJJPGO(out float3 NAOKAKLADHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D368E0", Offset = "0x5D358E0", VA = "0x185D368E0")]
	public void MPEBAFLLPBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D35900", Offset = "0x5D34900", VA = "0x185D35900")]
	public bool HAFIHHHOFEN(out float LJJHDOLPJOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D369B0", Offset = "0x5D359B0", VA = "0x185D369B0", Slot = "14")]
	public void NANHMOGKJKJ((Quaternion rot, Vector3 moments) DKHOIHPOENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D36620", Offset = "0x5D35620", VA = "0x185D36620", Slot = "16")]
	public void MIGNLHGCABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D35580", Offset = "0x5D34580", VA = "0x185D35580", Slot = "15")]
	public void FPKLGKNCPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x5D36020", Offset = "0x5D35020", VA = "0x185D36020", Slot = "18")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x5D362D0", Offset = "0x5D352D0", VA = "0x185D362D0", Slot = "19")]
	public void LNOPBHJDCOE(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x5D36160", Offset = "0x5D35160", VA = "0x185D36160", Slot = "17")]
	public void LGLOKNEEAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5D38250", Offset = "0x5D37250", VA = "0x185D38250", Slot = "20")]
	public void PMMIPEBHDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A6E0", Offset = "0x5D196E0", VA = "0x185D1A6E0")]
	public void BMKPOGOOMCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5D34DE0", Offset = "0x5D33DE0", VA = "0x185D34DE0")]
	private void CCMDHONJIPP(Vector3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5D34F20", Offset = "0x5D33F20", VA = "0x185D34F20")]
	[Obsolete]
	private Vector3 CGAIJNLPNAD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D353B0", Offset = "0x5D343B0", VA = "0x185D353B0")]
	private void NCAEEIONACK(float CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D38010", Offset = "0x5D37010", VA = "0x185D38010")]
	private Vector3 OOEJBKJJBEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D35D20", Offset = "0x5D34D20", VA = "0x185D35D20")]
	private Quaternion JGMJFLKGFMI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5D36D40", Offset = "0x5D35D40", VA = "0x185D36D40")]
	internal (float, Vector3) OLCKFEJDPHL(Rigidbody BBAOFCOHNND)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class JBFJKMFNABH
{
	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5D2ADE0", Offset = "0x5D29DE0", VA = "0x185D2ADE0")]
	public static KHHCOJHIJMK GLMNBFHIDJB(this GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class FKAFMAGKGFI : FDNGLPDCKHB, AKDKABCMEKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public FBBNGPOGPDF GDMLIKAFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x5D21410", Offset = "0x5D20410", VA = "0x185D21410", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D20650", Offset = "0x5D1F650", VA = "0x185D20650", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public PCCGNALJHJC IEFFEBPICJN
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D210A0", Offset = "0x5D200A0", VA = "0x185D210A0", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D1F7D0", Offset = "0x5D1E7D0", VA = "0x185D1F7D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	public Vector3 CJHFGNNEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D1FFD0", Offset = "0x5D1EFD0", VA = "0x185D1FFD0", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D1ED10", Offset = "0x5D1DD10", VA = "0x185D1ED10", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	public Vector3 DBLBMIIKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EDD0", Offset = "0x5D1DDD0", VA = "0x185D1EDD0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D1FB50", Offset = "0x5D1EB50", VA = "0x185D1FB50", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public Vector3 HCEGPGILCGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D1FAF0", Offset = "0x5D1EAF0", VA = "0x185D1FAF0", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x5D20F70", Offset = "0x5D1FF70", VA = "0x185D20F70", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public Vector3 BHGOINLEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x5D20F40", Offset = "0x5D1FF40", VA = "0x185D20F40", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E6D0", Offset = "0x5D1D6D0", VA = "0x185D1E6D0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public float PBKPBDBPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x5D21540", Offset = "0x5D20540", VA = "0x185D21540", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x5D21030", Offset = "0x5D20030", VA = "0x185D21030", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool ICIMBBIGOLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x5D218C0", Offset = "0x5D208C0", VA = "0x185D218C0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	private FCIFCFBJPFF DPEMCCDKENE
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x22D3310", Offset = "0x22D2310", VA = "0x1822D3310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	private bool NIECADIBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AF50", Offset = "0x5D19F50", VA = "0x185D1AF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D185A0", Offset = "0x5D175A0", VA = "0x185D185A0")]
	public FKAFMAGKGFI(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D203C0", Offset = "0x5D1F3C0", VA = "0x185D203C0", Slot = "20")]
	public void JCHDKKLHDLC(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D20A60", Offset = "0x5D1FA60", VA = "0x185D20A60", Slot = "31")]
	public void LOJJDJMIBDL(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EF30", Offset = "0x5D1DF30", VA = "0x185D1EF30", Slot = "19")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EE00", Offset = "0x5D1DE00", VA = "0x185D1EE00", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D20610", Offset = "0x5D1F610", VA = "0x185D20610", Slot = "28")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5D20B50", Offset = "0x5D1FB50", VA = "0x185D20B50", Slot = "36")]
	public Vector3 MBJCIOAOPLA(Vector3 JIBAOMFGMOP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5D20030", Offset = "0x5D1F030", VA = "0x185D20030", Slot = "35")]
	public Vector3 IPGPGFJKEGH(Vector3 BEGLMLACECH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EF30", Offset = "0x5D1DF30", VA = "0x185D1EF30", Slot = "27")]
	public void OBOCHBKOAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F790", Offset = "0x5D1E790", VA = "0x185D1F790", Slot = "25")]
	public void FJIMPNLFGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x5D20D30", Offset = "0x5D1FD30", VA = "0x185D20D30", Slot = "24")]
	public void MLMACKBHHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E490", Offset = "0x5D1D490", VA = "0x185D1E490", Slot = "34")]
	public void CIJCEOHOIFH(Vector3 HKJCBCHFCPK, Vector3 IKOKBFBENAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5D21040", Offset = "0x5D20040", VA = "0x185D21040", Slot = "33")]
	public void NNONEIIDODB(Vector3 HLEKEMPNOFO, Vector3 HALOBGHOELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F8C0", Offset = "0x5D1E8C0", VA = "0x185D1F8C0", Slot = "32")]
	public void GNHFMHHHPJP(Vector3 GLHHKKHDPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F370", Offset = "0x5D1E370", VA = "0x185D1F370", Slot = "22")]
	public void FHIGAJBINGD(ICCDFEDDHBO PPEJEAKNDAO, Vector3 CINGCIOKEJN, float LOILAGEIMBB, float PBCAKBEJADJ = 8f, float KLJFGNKNFHH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5D211D0", Offset = "0x5D201D0", VA = "0x185D211D0", Slot = "21")]
	public void NPMAPGEAPOM(HKBPFCIHPDB AGONOFKHJKP, Vector3 MMCFJBKAPNO, float LPIFLMOBAEB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5D20740", Offset = "0x5D1F740", VA = "0x185D20740", Slot = "23")]
	[Obsolete]
	public void LCMNPPLAMEK(HKBPFCIHPDB AGONOFKHJKP, Vector3 NMKLOHCPMNL, float ABJOHFIBNNH = 7f, float LIPCNPEMHDI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DE70", Offset = "0x5D1CE70", VA = "0x185D1DE70", Slot = "30")]
	public Vector3 BABHBPECAMD(Vector3 DIGLJLOIALF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E390", Offset = "0x5D1D390", VA = "0x185D1E390", Slot = "29")]
	public Vector3 BPDJEMCGEHA(Vector3 BFOCKHBKDDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5D204B0", Offset = "0x5D1F4B0", VA = "0x185D204B0", Slot = "26")]
	public void JOICJIPFNHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5D201F0", Offset = "0x5D1F1F0", VA = "0x185D201F0")]
	private void IPOMEKCHAEE(float CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5D20D70", Offset = "0x5D1FD70", VA = "0x185D20D70")]
	private void MMLFBOLBGFO(Vector3 MMCFJBKAPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F0C0", Offset = "0x5D1E0C0", VA = "0x185D1F0C0")]
	private Vector3 FEBKPGFKPFI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DF30", Offset = "0x5D1CF30", VA = "0x185D1DF30")]
	private void BKKGANEMFBP(Vector3 BEGLMLACECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x5D21610", Offset = "0x5D20610", VA = "0x185D21610")]
	private Vector3 PIFCIBMMDHL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FB80", Offset = "0x5D1EB80", VA = "0x185D1FB80")]
	private void IABEFBMKNFC(Vector3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FA90", Offset = "0x5D1EA90", VA = "0x185D1FA90")]
	private void GPCKNDNMFAL(Vector3 DIGLJLOIALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F060", Offset = "0x5D1E060", VA = "0x185D1F060")]
	private void EJMALDOIAGD(Vector3 BFOCKHBKDDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5D1E700", Offset = "0x5D1D700", VA = "0x185D1E700")]
	private void DIJLNCPGLOO(string KEDJIJINBJB, Vector3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EFA0", Offset = "0x5D1DFA0", VA = "0x185D1EFA0")]
	private void EIEAKDOGBLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal sealed class MKOCIKGPMKF : FDNGLPDCKHB, EOEFLBEIKKI
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public float DEGADDEAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x719DB60", Offset = "0x719CB60", VA = "0x18719DB60", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x719DCB0", Offset = "0x719CCB0", VA = "0x18719DCB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public float IEHKIAHDHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x719D740", Offset = "0x719C740", VA = "0x18719D740", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x719D820", Offset = "0x719C820", VA = "0x18719D820", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x719DE20", Offset = "0x719CE20", VA = "0x18719DE20")]
	public MKOCIKGPMKF(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x719D990", Offset = "0x719C990", VA = "0x18719D990", Slot = "8")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x719DC40", Offset = "0x719CC40", VA = "0x18719DC40", Slot = "9")]
	public void LNOPBHJDCOE(Rigidbody JHKHONGEEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[UnityEngine.Scripting.Preserve]
public sealed class BPCCFGCLHGN : GKIJIJOABOO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly BPCCFGCLHGN HIEJPGCOIBA;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public RigidbodyEx IDLGNFGLHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public GameObject EBPNNJIDLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public Transform CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public IEnumerable<object> KGOEFBCIKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public GKIJIJOABOO HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x871150", Offset = "0x870150", VA = "0x180871150", Slot = "10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IReadOnlyList<GKIJIJOABOO> HCCPLAHGKNP
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x914C50", Offset = "0x913C50", VA = "0x180914C50", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public GKIJIJOABOO LGIBJPCGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x97E5E0", Offset = "0x97D5E0", VA = "0x18097E5E0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public bool KHGGKLLFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x90AF40", Offset = "0x909F40", VA = "0x18090AF40", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public bool ACONAACMEEO
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xC9A960", Offset = "0xC99960", VA = "0x180C9A960", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public bool DGEAHLNJGHA
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xC9A9F0", Offset = "0xC999F0", VA = "0x180C9A9F0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public FBBNGPOGPDF GDMLIKAFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x97E720", Offset = "0x97D720", VA = "0x18097E720", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x971FC0", Offset = "0x970FC0", VA = "0x180971FC0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public PCCGNALJHJC IEFFEBPICJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x9768A0", Offset = "0x9758A0", VA = "0x1809768A0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public float PBKPBDBPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xF033C0", Offset = "0xF023C0", VA = "0x180F033C0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xF026A0", Offset = "0xF016A0", VA = "0x180F026A0", Slot = "21")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Vector3 DBLBMIIKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x2BB08D0", Offset = "0x2BAF8D0", VA = "0x182BB08D0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x2BB0920", Offset = "0x2BAF920", VA = "0x182BB0920", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public Vector3 BHGOINLEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x17B6E80", Offset = "0x17B5E80", VA = "0x1817B6E80", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x17B27E0", Offset = "0x17B17E0", VA = "0x1817B27E0", Slot = "25")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public Vector3 CJHFGNNEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x17B6EA0", Offset = "0x17B5EA0", VA = "0x1817B6EA0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x17B2BE0", Offset = "0x17B1BE0", VA = "0x1817B2BE0", Slot = "27")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 HCEGPGILCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x185EEF0", Offset = "0x185DEF0", VA = "0x18185EEF0", Slot = "28")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public bool FMGAPBNGNOG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x991FD0", Offset = "0x990FD0", VA = "0x180991FD0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public bool HCBLINPELBF
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x992010", Offset = "0x991010", VA = "0x180992010", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public bool DADEEKAKCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x20D39E0", Offset = "0x20D29E0", VA = "0x1820D39E0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public bool ICIMBBIGOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x20D3A20", Offset = "0x20D2A20", VA = "0x1820D3A20", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public Vector3 HBJLINEEDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0xFA9F60", Offset = "0xFA8F60", VA = "0x180FA9F60", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public Vector3 HPLGGDFELMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x177C2C0", Offset = "0x177B2C0", VA = "0x18177C2C0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public Vector3 MJJEDHDHCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x185EEF0", Offset = "0x185DEF0", VA = "0x18185EEF0", Slot = "36")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "37")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public Vector3 OMLCGNPLGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x991D10", Offset = "0x990D10", VA = "0x180991D10", Slot = "38")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public float CCHBEOPHGCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1CB2FA0", Offset = "0x1CB1FA0", VA = "0x181CB2FA0", Slot = "39")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float HCPLDPOGKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xBB97C0", Offset = "0xBB87C0", VA = "0x180BB97C0", Slot = "40")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "41")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public Vector3 ENGONBLHLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x185EEF0", Offset = "0x185DEF0", VA = "0x18185EEF0", Slot = "42")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public Quaternion MGJBLPJDEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x1132090", Offset = "0x1131090", VA = "0x181132090", Slot = "43")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public float DEGADDEAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xBB97C0", Offset = "0xBB87C0", VA = "0x180BB97C0", Slot = "45")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "46")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public float IEHKIAHDHHO
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xBB97C0", Offset = "0xBB87C0", VA = "0x180BB97C0", Slot = "47")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "48")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public bool JNEKBGLIJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "49")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public bool GMDJHCKBNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public FMOMJHKLCHF HGMPDKIENND
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "51")]
		get
		{
			return default(FMOMJHKLCHF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "52")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public bool HBNNMGOPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x21A2000", Offset = "0x21A1000", VA = "0x1821A2000", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public Transform CPEPBHIJGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x11EC0D0", Offset = "0x11EB0D0", VA = "0x1811EC0D0", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public Transform ODCCNDECCIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x98E700", Offset = "0x98D700", VA = "0x18098E700", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public Vector3 OKHAADJKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x185EEF0", Offset = "0x185DEF0", VA = "0x18185EEF0", Slot = "56")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "57")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float NODLEALDIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xBB97C0", Offset = "0xBB87C0", VA = "0x180BB97C0", Slot = "58")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "59")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float EOEDBEBJIAE
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0xBB97C0", Offset = "0xBB87C0", VA = "0x180BB97C0", Slot = "60")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "61")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Quaternion IEIHNFGKHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x1095F00", Offset = "0x1094F00", VA = "0x181095F00", Slot = "62")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "63")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public Vector3 MHKFHAGBNLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x185EEF0", Offset = "0x185DEF0", VA = "0x18185EEF0", Slot = "64")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "65")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public Quaternion PPGNDJFMMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1095F00", Offset = "0x1094F00", VA = "0x181095F00", Slot = "66")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "67")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public RigidbodyConstraints BHPHKBKMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "68")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "69")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public bool EKBGPCJPIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "71")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public CollisionDetectionMode CFPICLDPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "72")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "73")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public bool DHDGIHLOMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0xA1CFC0", Offset = "0xA1BFC0", VA = "0x180A1CFC0", Slot = "74")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public bool CJHHFDCHPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "132")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002B")]
	public event CPDMFGNNCLB LCHFLBDEBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "79")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "80")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002C")]
	public event CPDMFGNNCLB OFOJPGDJBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "81")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "82")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002D")]
	public event DCOPMFBIBNC GAJMBFEEBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "83")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "84")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002E")]
	public event CPDMFGNNCLB KJGCJBOEFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "86")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "87")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400002F")]
	public event CPDMFGNNCLB FOLPMJHPPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "106")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "107")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000030")]
	public event CPDMFGNNCLB AALLMMHBBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "111")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "112")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000031")]
	public event Action<CDHDCBBOJLO, CDHDCBBOJLO> DAANECCDGFN
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "115")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "116")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000032")]
	public event CPDMFGNNCLB JBJICGHHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "117")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "118")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000033")]
	public event CPDMFGNNCLB IAFBKCIIOGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "123")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "124")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "44")]
	public void NANHMOGKJKJ((Quaternion rot, Vector3 moments) DKHOIHPOENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "75")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "76")]
	public void DCMCMHNNGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "77")]
	public void GEPBLOKJEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "78")]
	public void JCCAKBLBCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "140")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "85")]
	public void PELENMOAPPI(GKIJIJOABOO CKDFGEALFAK, bool KPNOPNBLPDN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "88")]
	public void CPPMPAIBAIE(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "89")]
	public void LGIPNJNGKEK(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x185EEF0", Offset = "0x185DEF0", VA = "0x18185EEF0", Slot = "90")]
	public Vector3 MBJCIOAOPLA(Vector3 JIBAOMFGMOP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x185EEF0", Offset = "0x185DEF0", VA = "0x18185EEF0", Slot = "91")]
	public Vector3 IPGPGFJKEGH(Vector3 BEGLMLACECH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "92")]
	public void OBOCHBKOAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "93")]
	public void FJIMPNLFGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "94")]
	public void MLMACKBHHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "95")]
	public void CIJCEOHOIFH(Vector3 HKJCBCHFCPK, Vector3 IKOKBFBENAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "96")]
	public void NNONEIIDODB(Vector3 HLEKEMPNOFO, Vector3 HALOBGHOELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "97")]
	public void GNHFMHHHPJP(Vector3 GLHHKKHDPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "98")]
	public void FHIGAJBINGD(ICCDFEDDHBO PPEJEAKNDAO, Vector3 CINGCIOKEJN, float LOILAGEIMBB, float PBCAKBEJADJ = 8f, float KLJFGNKNFHH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "99")]
	public void NPMAPGEAPOM(HKBPFCIHPDB AGONOFKHJKP, Vector3 MMCFJBKAPNO, float LPIFLMOBAEB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "100")]
	public void LCMNPPLAMEK(HKBPFCIHPDB AGONOFKHJKP, Vector3 NMKLOHCPMNL, float ABJOHFIBNNH = 7f, float LIPCNPEMHDI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x185EEF0", Offset = "0x185DEF0", VA = "0x18185EEF0", Slot = "101")]
	public Vector3 BABHBPECAMD(Vector3 CKDFGEALFAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x185EEF0", Offset = "0x185DEF0", VA = "0x18185EEF0", Slot = "102")]
	public Vector3 BPDJEMCGEHA(Vector3 CKDFGEALFAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "103")]
	public void JOICJIPFNHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "104")]
	public void HGGLKPKKAAI(GKIJIJOABOO APBHIBICBMG, object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "105")]
	public void CJJOPIHMMFK(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "108")]
	public void MIGNLHGCABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "109")]
	public void FPKLGKNCPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "110")]
	public void LGLOKNEEAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "113")]
	public bool BOKGHGDFDOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "114")]
	public void FMOBJOLKMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "119")]
	public IDisposable GACBMNJIACD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "120")]
	public void KAELNCJCGFP(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "121")]
	public void HOCNFCJLBPG(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "122")]
	public void GKJKMFOOEAJ(object FFKJLIDBALM, bool JODHJMHBHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "125")]
	public void GEDPKOALOFN(Vector3 GADCFFBMFPB, Quaternion OMAFNFIJLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "126")]
	public void CEBEBAGHPBA(Vector3 NHLFKICLGLO, Quaternion KDJHMFNDHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "127")]
	public bool PGHGAILNCBG(float JJMIOIPPABK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "128")]
	public void MGKFGHOJPBF(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "129")]
	public void OLJBIHPBAAM(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "130")]
	public void PKCJDHEHHKF(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "131")]
	public void MNPDLAIMCKF(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "133")]
	public void PJCLLEGFFHE(Vector3 HNGHLFFJCGK, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "134")]
	public void HJJLBECNANN(Vector3 HNGHLFFJCGK, Vector3 NKMKMKDMOMJ, ForceMode MJBIGEIBMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "135")]
	public void LMJMOPPPAJB(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "136")]
	public void BBEKPKFIJJP(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D19720", Offset = "0x5D18720", VA = "0x185D19720", Slot = "137")]
	public bool KDILDFBMPIF(Vector3 HCEFOMOBPKF, out RaycastHit CGLNBILMEGG, float FJDPGBJBEDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "138")]
	public void PMMIPEBHDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public BPCCFGCLHGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal sealed class GFEMHCODACH : FDNGLPDCKHB, EPGNOJDAMLC
{
	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public Vector3 HBJLINEEDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D28080", Offset = "0x5D27080", VA = "0x185D28080", Slot = "4")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public Vector3 HPLGGDFELMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D278B0", Offset = "0x5D268B0", VA = "0x185D278B0", Slot = "5")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	private Vector3 CJHFGNNEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x5D27AB0", Offset = "0x5D26AB0", VA = "0x185D27AB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	private GKIJIJOABOO JMAGIBIDIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x5D27F20", Offset = "0x5D26F20", VA = "0x185D27F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D185A0", Offset = "0x5D175A0", VA = "0x185D185A0")]
	public GFEMHCODACH(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5D27CB0", Offset = "0x5D26CB0", VA = "0x185D27CB0", Slot = "6")]
	public void JBLFGKCHBNP(GKIJIJOABOO DJAGPEDCGHG, object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D27B90", Offset = "0x5D26B90", VA = "0x185D27B90")]
	private void JBLFGKCHBNP(PICOGHEPFKI DJAGPEDCGHG, object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D27E30", Offset = "0x5D26E30", VA = "0x185D27E30", Slot = "7")]
	public void JGFDPLBGHAE(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D27550", Offset = "0x5D26550", VA = "0x185D27550")]
	private Vector3 DHFDDBMEDEF()
	{
		return default(Vector3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal static class ADHELCGJNEI
{
	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D17A70", Offset = "0x5D16A70", VA = "0x185D17A70")]
	public static GFEMHCODACH CNMOIJBGJEI(this GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
internal sealed class JPBFELBGKFP : FDNGLPDCKHB, HNNBMDLKLHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly HPPHLHFLMDP NJOKCIGABEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly MFNOFJAHCPE DLFDDHKPOLG;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private Transform CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5D329E0", Offset = "0x5D319E0", VA = "0x185D329E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public HKCCJJBDGFK KFBIIMCMKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D32D30", Offset = "0x5D31D30", VA = "0x185D32D30")]
		get
		{
			return default(HKCCJJBDGFK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D33B90", Offset = "0x5D32B90", VA = "0x185D33B90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public GKIJIJOABOO HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D33370", Offset = "0x5D32370", VA = "0x185D33370", Slot = "24")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D33A80", Offset = "0x5D32A80", VA = "0x185D33A80", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public HKCCJJBDGFK DBAELPHOIJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D340E0", Offset = "0x5D330E0", VA = "0x185D340E0")]
		get
		{
			return default(HKCCJJBDGFK);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D32740", Offset = "0x5D31740", VA = "0x185D32740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public GKIJIJOABOO LGIBJPCGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5D33C90", Offset = "0x5D32C90", VA = "0x185D33C90", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IReadOnlyList<GKIJIJOABOO> HCCPLAHGKNP
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000034")]
	public event CPDMFGNNCLB LCHFLBDEBGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5D33E10", Offset = "0x5D32E10", VA = "0x185D33E10", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x5D31FA0", Offset = "0x5D30FA0", VA = "0x185D31FA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000035")]
	public event CPDMFGNNCLB OFOJPGDJBLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5D33770", Offset = "0x5D32770", VA = "0x185D33770", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5D33CD0", Offset = "0x5D32CD0", VA = "0x185D33CD0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000036")]
	public event DCOPMFBIBNC GAJMBFEEBCI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x5D33810", Offset = "0x5D32810", VA = "0x185D33810", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5D332D0", Offset = "0x5D322D0", VA = "0x185D332D0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000037")]
	public event Action JDHEPKFGNNG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D33230", Offset = "0x5D32230", VA = "0x185D33230", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5D32C90", Offset = "0x5D31C90", VA = "0x185D32C90", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000038")]
	public event Action HHMCDAKEEHN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D34040", Offset = "0x5D33040", VA = "0x185D34040", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5D33FA0", Offset = "0x5D32FA0", VA = "0x185D33FA0", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000039")]
	public event Action<GKIJIJOABOO> AMMFMNEEOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5D33AF0", Offset = "0x5D32AF0", VA = "0x185D33AF0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5D33630", Offset = "0x5D32630", VA = "0x185D33630", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003A")]
	public event Action<GKIJIJOABOO> NKLGELOFNCG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5D336D0", Offset = "0x5D326D0", VA = "0x185D336D0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x5D33590", Offset = "0x5D32590", VA = "0x185D33590", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003B")]
	public event Action MNMELFCLPCA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D33D70", Offset = "0x5D32D70", VA = "0x185D33D70", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5D33190", Offset = "0x5D32190", VA = "0x185D33190", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003C")]
	public event Action<GKIJIJOABOO> CEGKOKMJALM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5D32BF0", Offset = "0x5D31BF0", VA = "0x185D32BF0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5D339E0", Offset = "0x5D329E0", VA = "0x185D339E0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D34270", Offset = "0x5D33270", VA = "0x185D34270")]
	public JPBFELBGKFP(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x5D32A10", Offset = "0x5D31A10", VA = "0x185D32A10", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5D33F20", Offset = "0x5D32F20", VA = "0x185D33F20", Slot = "26")]
	public void PELENMOAPPI(GKIJIJOABOO GFJHNOHABFL, bool KPNOPNBLPDN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x5D33EB0", Offset = "0x5D32EB0", VA = "0x185D33EB0")]
	private void PELENMOAPPI(PICOGHEPFKI GFJHNOHABFL, bool KPNOPNBLPDN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5D32110", Offset = "0x5D31110", VA = "0x185D32110")]
	private void BAFBDBNJMPN(PICOGHEPFKI GFJHNOHABFL, bool KPNOPNBLPDN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D32FF0", Offset = "0x5D31FF0", VA = "0x185D32FF0")]
	private void FMLGHJBFLJE(PICOGHEPFKI BPJPHGOLFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D32840", Offset = "0x5D31840", VA = "0x185D32840")]
	private void DILOLFLPDFN(PICOGHEPFKI BPJPHGOLFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D32E30", Offset = "0x5D31E30", VA = "0x185D32E30")]
	private void FDBGLBAJPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D32040", Offset = "0x5D31040", VA = "0x185D32040")]
	private void ANGOBBCBGEI(PICOGHEPFKI BPJPHGOLFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D334E0", Offset = "0x5D324E0", VA = "0x185D334E0")]
	private void JJMLJFCKNKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D338B0", Offset = "0x5D328B0", VA = "0x185D338B0")]
	private void MDHEGCDPHGI(PICOGHEPFKI HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D333B0", Offset = "0x5D323B0", VA = "0x185D333B0")]
	private void HIJNKPPMGLM(PICOGHEPFKI HAPBMPEEKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal static class MPBDHAHAOKD
{
	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x719DE30", Offset = "0x719CE30", VA = "0x18719DE30")]
	public static JPBFELBGKFP NJDJFHLCGOF(this GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class PICOGHEPFKI : JLDKEPCIJOL, KEDINEBOMHC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	internal HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	internal HIOAPONHMCI HCLKOOOAMOF;

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x71A2DC0", Offset = "0x71A1DC0", VA = "0x1871A2DC0")]
	public PICOGHEPFKI(GameObject LAPEIFCGFLM, RigidbodyEx OJGIKIHBCKE, JAKOFGLBKHL ALPIPCHDOEM, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x71A2AE0", Offset = "0x71A1AE0", VA = "0x1871A2AE0", Slot = "142")]
	protected override void PFHMHDJMFKF(JAKOFGLBKHL ALPIPCHDOEM, IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8682E0", Offset = "0x8672E0", VA = "0x1808682E0", Slot = "145")]
	protected override IDisposable PPEIEDAFEAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x71A2650", Offset = "0x71A1650", VA = "0x1871A2650", Slot = "143")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x71A2450", Offset = "0x71A1450", VA = "0x1871A2450", Slot = "146")]
	public void BHDEJNEOEEL(POLDHLFEBIN BEKGPJHMFFJ, POLDHLFEBIN HEIIEHCMKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x71A2720", Offset = "0x71A1720", VA = "0x1871A2720", Slot = "147")]
	public void ELJGHOKOJKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x71A2A20", Offset = "0x71A1A20", VA = "0x1871A2A20", Slot = "148")]
	public void OMHCFHCLCNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x71A23F0", Offset = "0x71A13F0", VA = "0x1871A23F0", Slot = "149")]
	public void ADKDLIBNMCE(bool FGLGAHABBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x71A2510", Offset = "0x71A1510", VA = "0x1871A2510", Slot = "150")]
	public bool DCNNJMCONGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x71A27E0", Offset = "0x71A17E0", VA = "0x1871A27E0", Slot = "151")]
	public void FOJNAFIKPMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "144")]
	protected override void LPLNMBKILNL(RigidbodyEx LPGJKBJMDHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x71A2840", Offset = "0x71A1840", VA = "0x1871A2840")]
	private void GOMDFLAONKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal static class PJDJNOICAKI
{
	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x71A2DD0", Offset = "0x71A1DD0", VA = "0x1871A2DD0")]
	public static JLDKEPCIJOL NICICKFEKML(this GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
internal sealed class HAGBOPHCLIE : FDNGLPDCKHB, PGHHFLOFLBF
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private const string MMLCDACPJAK = "INTERP_PAUSE";

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public bool ADLCDDONGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D29480", Offset = "0x5D28480", VA = "0x185D29480", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public FLACBGLBMKA CKAGLECBIDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x5D28B40", Offset = "0x5D27B40", VA = "0x185D28B40", Slot = "5")]
		get
		{
			return default(FLACBGLBMKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private FLACBGLBMKA BMIKOKKMLHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D29280", Offset = "0x5D28280", VA = "0x185D29280")]
		get
		{
			return default(FLACBGLBMKA);
		}
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D29390", Offset = "0x5D28390", VA = "0x185D29390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D29550", Offset = "0x5D28550", VA = "0x185D29550")]
	public HAGBOPHCLIE(GKIJIJOABOO HAPBMPEEKBC, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D28E00", Offset = "0x5D27E00", VA = "0x185D28E00", Slot = "6")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D28C60", Offset = "0x5D27C60", VA = "0x185D28C60")]
	private bool BJPNJAJHCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D29180", Offset = "0x5D28180", VA = "0x185D29180", Slot = "7")]
	public void HNEHOALDMKJ(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D28D00", Offset = "0x5D27D00", VA = "0x185D28D00", Slot = "8")]
	public void CHDOAHKLOJM(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D28B50", Offset = "0x5D27B50", VA = "0x185D28B50", Slot = "11")]
	public void BCFHKCJHAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D29050", Offset = "0x5D28050", VA = "0x185D29050")]
	private void FOFDBOFCKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D28EC0", Offset = "0x5D27EC0", VA = "0x185D28EC0")]
	private void EFEGAMFCMOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D29350", Offset = "0x5D28350", VA = "0x185D29350", Slot = "10")]
	public void NMLFHJHIDFH(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D29140", Offset = "0x5D28140", VA = "0x185D29140", Slot = "9")]
	public void HCBFOLLPIFP(GKIJIJOABOO HAPBMPEEKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal sealed class CDJFKBCNADH : FDNGLPDCKHB, FCIFCFBJPFF
{
	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x5D19E60", Offset = "0x5D18E60", VA = "0x185D19E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private bool HBNNMGOPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x5D19E10", Offset = "0x5D18E10", VA = "0x185D19E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	private bool KHGGKLLFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x5D18A00", Offset = "0x5D17A00", VA = "0x185D18A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	private GKIJIJOABOO HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x5D19B10", Offset = "0x5D18B10", VA = "0x185D19B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D185A0", Offset = "0x5D175A0", VA = "0x185D185A0")]
	public CDJFKBCNADH(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A580", Offset = "0x5D19580", VA = "0x185D1A580", Slot = "4")]
	public void PJCLLEGFFHE(Vector3 HNGHLFFJCGK, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A010", Offset = "0x5D19010", VA = "0x185D1A010")]
	private void NNLAAGPKJCK(Vector3 HNGHLFFJCGK, ForceMode MJBIGEIBMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5D19B70", Offset = "0x5D18B70", VA = "0x185D19B70", Slot = "5")]
	public void HJJLBECNANN(Vector3 HNGHLFFJCGK, Vector3 NKMKMKDMOMJ, ForceMode MJBIGEIBMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5D19EB0", Offset = "0x5D18EB0", VA = "0x185D19EB0", Slot = "6")]
	public void LMJMOPPPAJB(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A300", Offset = "0x5D19300", VA = "0x185D1A300")]
	private void PGINFGJBNFK(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5D19890", Offset = "0x5D18890", VA = "0x185D19890", Slot = "7")]
	public void BBEKPKFIJJP(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5D197A0", Offset = "0x5D187A0", VA = "0x185D197A0")]
	private void AHJGPEGCGMK(string HJJLMCEMDKN, UnityEngine.Object AEOEKGNDHFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
internal sealed class FLLEPNHEEDD : FDNGLPDCKHB, NKPFENENCON
{
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private const string CMFMMDKEHCP = "RBEX_ANIM";

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x5D22670", Offset = "0x5D21670", VA = "0x185D22670", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x5D21B70", Offset = "0x5D20B70", VA = "0x185D21B70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private bool KHGGKLLFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5D18A00", Offset = "0x5D17A00", VA = "0x185D18A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public bool CJHHFDCHPNM
	{
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x5D21E20", Offset = "0x5D20E20", VA = "0x185D21E20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x5D22940", Offset = "0x5D21940", VA = "0x185D22940")]
	public FLLEPNHEEDD(GKIJIJOABOO HAPBMPEEKBC, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5D21EF0", Offset = "0x5D20EF0", VA = "0x185D21EF0", Slot = "5")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5D22840", Offset = "0x5D21840", VA = "0x185D22840", Slot = "7")]
	public void PKCJDHEHHKF(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5D22740", Offset = "0x5D21740", VA = "0x185D22740", Slot = "8")]
	public void MNPDLAIMCKF(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5D22200", Offset = "0x5D21200", VA = "0x185D22200", Slot = "9")]
	public void GBLJPONPLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5D21FA0", Offset = "0x5D20FA0", VA = "0x185D21FA0", Slot = "10")]
	public void FFCBJIOHPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5D219A0", Offset = "0x5D209A0", VA = "0x185D219A0", Slot = "11")]
	public void ALFOHLKNOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "12")]
	public void NABHAJFKIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x5D21C60", Offset = "0x5D20C60", VA = "0x185D21C60")]
	private void CEMCAOCAGJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5D224B0", Offset = "0x5D214B0", VA = "0x185D224B0")]
	private void HAIABNGGBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
internal sealed class KHAFEMOENIA : FDNGLPDCKHB, COLFKEAIKIE
{
	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public bool HBNNMGOPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x5D34780", Offset = "0x5D33780", VA = "0x185D34780", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public IEnumerable<object> NKMCCLFKAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x5D34A30", Offset = "0x5D33A30", VA = "0x185D34A30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	private bool DGGLMAFGGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x5D34CE0", Offset = "0x5D33CE0", VA = "0x185D34CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003D")]
	public event CPDMFGNNCLB JBJICGHHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5D34630", Offset = "0x5D33630", VA = "0x185D34630", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x5D346E0", Offset = "0x5D336E0", VA = "0x185D346E0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5D185A0", Offset = "0x5D175A0", VA = "0x185D185A0")]
	public KHAFEMOENIA(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x5D34470", Offset = "0x5D33470", VA = "0x185D34470", Slot = "12")]
	public IDisposable GACBMNJIACD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x5D34A20", Offset = "0x5D33A20", VA = "0x185D34A20", Slot = "9")]
	public void KAELNCJCGFP(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5D346D0", Offset = "0x5D336D0", VA = "0x185D346D0", Slot = "10")]
	public void HOCNFCJLBPG(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5D34530", Offset = "0x5D33530", VA = "0x185D34530", Slot = "11")]
	public void GKJKMFOOEAJ(object FFKJLIDBALM, bool JODHJMHBHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5D34850", Offset = "0x5D33850", VA = "0x185D34850", Slot = "13")]
	public void JPPEJFNNKOF(Rigidbody CIEJBNMPJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5D34B00", Offset = "0x5D33B00", VA = "0x185D34B00", Slot = "14")]
	public void LNOPBHJDCOE(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A6E0", Offset = "0x5D196E0", VA = "0x185D1A6E0", Slot = "6")]
	public void IPKMBAHFCID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
internal sealed class HIJFGEPILAM : FDNGLPDCKHB, KCLMAFFCLOC
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private CollisionDetectionMode MIFEDMOLACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A360", Offset = "0x5D29360", VA = "0x185D2A360")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x5D2AAE0", Offset = "0x5D29AE0", VA = "0x185D2AAE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x5D19E60", Offset = "0x5D18E60", VA = "0x185D19E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public CollisionDetectionMode CFPICLDPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A740", Offset = "0x5D29740", VA = "0x185D2A740", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A860", Offset = "0x5D29860", VA = "0x185D2A860", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5D185A0", Offset = "0x5D175A0", VA = "0x185D185A0")]
	public HIJFGEPILAM(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A430", Offset = "0x5D29430", VA = "0x185D2A430", Slot = "6")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A8E0", Offset = "0x5D298E0", VA = "0x185D2A8E0", Slot = "9")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A850", Offset = "0x5D29850", VA = "0x185D2A850", Slot = "7")]
	public void HMCOBLAMCNB(bool DCBEHDNEFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2ABD0", Offset = "0x5D29BD0", VA = "0x185D2ABD0", Slot = "8")]
	public void OKAEEFDELAJ(bool DCBEHDNEFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A970", Offset = "0x5D29970", VA = "0x185D2A970", Slot = "10")]
	public bool KDILDFBMPIF(Vector3 HCEFOMOBPKF, out RaycastHit CGLNBILMEGG, float FJDPGBJBEDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A540", Offset = "0x5D29540", VA = "0x185D2A540")]
	private void EHPIMPPJBEO(bool DCBEHDNEFPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[DefaultMember("Item")]
public sealed class MFNOFJAHCPE : IReadOnlyList<GKIJIJOABOO>, IEnumerable<GKIJIJOABOO>, IEnumerable, IReadOnlyCollection<GKIJIJOABOO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public readonly HIOAPONHMCI KNEFBFDLNNH;

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x719CE20", Offset = "0x719BE20", VA = "0x18719CE20", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public GKIJIJOABOO CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x719CEF0", Offset = "0x719BEF0", VA = "0x18719CEF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x719CDD0", Offset = "0x719BDD0", VA = "0x18719CDD0")]
	public MFNOFJAHCPE(HKCCJJBDGFK IFPLGBGLLJH, HIOAPONHMCI KNEFBFDLNNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x719CC30", Offset = "0x719BC30", VA = "0x18719CC30", Slot = "6")]
	public IEnumerator<GKIJIJOABOO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x719CC30", Offset = "0x719BC30", VA = "0x18719CC30", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x719CDC0", Offset = "0x719BDC0", VA = "0x18719CDC0")]
	[CompilerGenerated]
	private GKIJIJOABOO HMJPLKNMJND(int KJPGMJFNNHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MGKHKOKKBFA : KDBIAHFONJN
{
	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x719D6E0", Offset = "0x719C6E0", VA = "0x18719D6E0", Slot = "4")]
	public HNNBMDLKLHB OGBHICJOKHL(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x719D620", Offset = "0x719C620", VA = "0x18719D620", Slot = "5")]
	public AKDKABCMEKE NANJCOFPMIJ(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x719D680", Offset = "0x719C680", VA = "0x18719D680", Slot = "6")]
	public EPGNOJDAMLC NJEEJAHAMHC(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x719D490", Offset = "0x719C490", VA = "0x18719D490", Slot = "7")]
	public EOEFLBEIKKI LCGLDAEIICG(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x719D4F0", Offset = "0x719C4F0", VA = "0x18719D4F0", Slot = "8")]
	public PKIFEAFNLDP LDIKLAKHKJI(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x719D550", Offset = "0x719C550", VA = "0x18719D550", Slot = "9")]
	public AALKHMIGOHM LKNBBLKOCDK(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x719D1D0", Offset = "0x719C1D0", VA = "0x18719D1D0", Slot = "10")]
	public COLFKEAIKIE DJBBMFHFDGM(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x719D110", Offset = "0x719C110", VA = "0x18719D110", Slot = "11")]
	public FCIFCFBJPFF BOCAPHJPMGD(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x719D310", Offset = "0x719C310", VA = "0x18719D310", Slot = "12")]
	public KCLMAFFCLOC FHOHPFBKKPC(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x719D170", Offset = "0x719C170", VA = "0x18719D170", Slot = "13")]
	public DNPNOKFCKLA CDHFFHIJPAO(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x719D230", Offset = "0x719C230", VA = "0x18719D230")]
	public NKPFENENCON GPLNLPNFGLB(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x719D0A0", Offset = "0x719C0A0", VA = "0x18719D0A0")]
	public IOJACBLDOHM BGLAILFIDDF(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x719D370", Offset = "0x719C370", VA = "0x18719D370")]
	public PGHHFLOFLBF FJGPAKPMDJL(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x719D5B0", Offset = "0x719C5B0", VA = "0x18719D5B0")]
	public IEOOEGFPLID MHDNBLBJAIO(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x719D2A0", Offset = "0x719C2A0", VA = "0x18719D2A0")]
	public GFGHHLGFFPG GDIPABKDHBG(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x719D3E0", Offset = "0x719C3E0", VA = "0x18719D3E0", Slot = "19")]
	public GKIJIJOABOO JEBPGNPPFJB(RigidbodyEx HAPBMPEEKBC, IMBADAJGPJF HHCEHFFEAKN, JAKOFGLBKHL ALPIPCHDOEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MGKHKOKKBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x719D230", Offset = "0x719C230", VA = "0x18719D230", Slot = "14")]
	private NKPFENENCON DPHCLCDGBJE(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x719D0A0", Offset = "0x719C0A0", VA = "0x18719D0A0", Slot = "15")]
	private IOJACBLDOHM KBFMIFJFFEJ(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x719D370", Offset = "0x719C370", VA = "0x18719D370", Slot = "16")]
	private PGHHFLOFLBF NMOOLFIBCCA(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x719D5B0", Offset = "0x719C5B0", VA = "0x18719D5B0", Slot = "17")]
	private IEOOEGFPLID MDJPFAFDAOJ(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x719D2A0", Offset = "0x719C2A0", VA = "0x18719D2A0", Slot = "18")]
	private GFGHHLGFFPG EGPGHALEDGN(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal sealed class CDPNIENNILB : FDNGLPDCKHB, PKIFEAFNLDP
{
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public const int JLALFMANINA = 10;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public const float ABBIPMGAIGG = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public const float BHDPBNIKPLJ = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public const float CDCBFPINPFE = 5f;

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	private Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x5D19E60", Offset = "0x5D18E60", VA = "0x185D19E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	private bool JHJJMGPLNLN
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B530", Offset = "0x5D1A530", VA = "0x185D1B530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	private bool NIECADIBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AF50", Offset = "0x5D19F50", VA = "0x185D1AF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private GKIJIJOABOO HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AF70", Offset = "0x5D19F70", VA = "0x185D1AF70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private bool KHGGKLLFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AC80", Offset = "0x5D19C80", VA = "0x185D1AC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private bool HNLACPGPPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AB00", Offset = "0x5D19B00", VA = "0x185D1AB00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B1F0", Offset = "0x5D1A1F0", VA = "0x185D1B1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private bool CDOCKHCIGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AFD0", Offset = "0x5D19FD0", VA = "0x185D1AFD0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B2E0", Offset = "0x5D1A2E0", VA = "0x185D1B2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private int AIMEGKMFDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x5D1ACE0", Offset = "0x5D19CE0", VA = "0x185D1ACE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AE60", Offset = "0x5D19E60", VA = "0x185D1AE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003E")]
	public event CPDMFGNNCLB AALLMMHBBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B5D0", Offset = "0x5D1A5D0", VA = "0x185D1B5D0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x5D1B150", Offset = "0x5D1A150", VA = "0x185D1B150", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B680", Offset = "0x5D1A680", VA = "0x185D1B680")]
	public CDPNIENNILB(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ABD0", Offset = "0x5D19BD0", VA = "0x185D1ABD0", Slot = "6")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B670", Offset = "0x5D1A670", VA = "0x185D1B670", Slot = "8")]
	public void PMKDOCIKNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A8E0", Offset = "0x5D198E0", VA = "0x185D1A8E0", Slot = "7")]
	public bool BOKGHGDFDOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B0A0", Offset = "0x5D1A0A0", VA = "0x185D1B0A0", Slot = "9")]
	public void JCCAKBLBCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A6E0", Offset = "0x5D196E0", VA = "0x185D1A6E0", Slot = "12")]
	public void ADKDLIBNMCE(bool FGLGAHABBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x5D1ADB0", Offset = "0x5D19DB0", VA = "0x185D1ADB0", Slot = "11")]
	public void FMOBJOLKMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "10")]
	public void GEEAFJLCCHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x5D1A720", Offset = "0x5D19720", VA = "0x185D1A720")]
	private bool BDLLHMNOABH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B3D0", Offset = "0x5D1A3D0", VA = "0x185D1B3D0")]
	private void MKHMCBLNGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[HCLCMACKFGM(typeof(KDBIAHFONJN), new string[] { })]
public class PGNAGPLIHMM : KDBIAHFONJN, ALCJCBIJLHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly KDBIAHFONJN EFIEMALKIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly KDBIAHFONJN FCNMAPMEDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private CMKCAGGCPGO NNLEOFACMGC;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private KDBIAHFONJN PHOPMMJHKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x71A1990", Offset = "0x71A0990", VA = "0x1871A1990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0x71A1D40", Offset = "0x71A0D40", VA = "0x1871A1D40", Slot = "20")]
	public void InitReferences(CNIJJDNAGNG HFACFBNIDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x71A22B0", Offset = "0x71A12B0", VA = "0x1871A22B0", Slot = "4")]
	public HNNBMDLKLHB OGBHICJOKHL(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x71A2170", Offset = "0x71A1170", VA = "0x1871A2170", Slot = "5")]
	public AKDKABCMEKE NANJCOFPMIJ(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x71A2210", Offset = "0x71A1210", VA = "0x1871A2210", Slot = "6")]
	public EPGNOJDAMLC NJEEJAHAMHC(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x71A1EE0", Offset = "0x71A0EE0", VA = "0x1871A1EE0", Slot = "7")]
	public EOEFLBEIKKI LCGLDAEIICG(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x71A1F80", Offset = "0x71A0F80", VA = "0x1871A1F80", Slot = "8")]
	public PKIFEAFNLDP LDIKLAKHKJI(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0x71A2020", Offset = "0x71A1020", VA = "0x1871A2020", Slot = "9")]
	public AALKHMIGOHM LKNBBLKOCDK(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x71A19F0", Offset = "0x71A09F0", VA = "0x1871A19F0", Slot = "10")]
	public COLFKEAIKIE DJBBMFHFDGM(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0x71A1850", Offset = "0x71A0850", VA = "0x1871A1850", Slot = "11")]
	public FCIFCFBJPFF BOCAPHJPMGD(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x71A1BF0", Offset = "0x71A0BF0", VA = "0x1871A1BF0", Slot = "12")]
	public KCLMAFFCLOC FHOHPFBKKPC(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x71A18F0", Offset = "0x71A08F0", VA = "0x1871A18F0", Slot = "13")]
	public DNPNOKFCKLA CDHFFHIJPAO(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x71A1A90", Offset = "0x71A0A90", VA = "0x1871A1A90")]
	public NKPFENENCON GPLNLPNFGLB(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x71A17A0", Offset = "0x71A07A0", VA = "0x1871A17A0")]
	public IOJACBLDOHM BGLAILFIDDF(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x71A1C90", Offset = "0x71A0C90", VA = "0x1871A1C90")]
	public PGHHFLOFLBF FJGPAKPMDJL(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x71A20C0", Offset = "0x71A10C0", VA = "0x1871A20C0")]
	public IEOOEGFPLID MHDNBLBJAIO(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x71A1B40", Offset = "0x71A0B40", VA = "0x1871A1B40")]
	public GFGHHLGFFPG GDIPABKDHBG(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x71A1D90", Offset = "0x71A0D90", VA = "0x1871A1D90", Slot = "19")]
	public GKIJIJOABOO JEBPGNPPFJB(RigidbodyEx HAPBMPEEKBC, IMBADAJGPJF HHCEHFFEAKN, JAKOFGLBKHL ALPIPCHDOEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x71A2350", Offset = "0x71A1350", VA = "0x1871A2350")]
	public PGNAGPLIHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x71A1A90", Offset = "0x71A0A90", VA = "0x1871A1A90", Slot = "14")]
	private NKPFENENCON DPHCLCDGBJE(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x71A17A0", Offset = "0x71A07A0", VA = "0x1871A17A0", Slot = "15")]
	private IOJACBLDOHM KBFMIFJFFEJ(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0x71A1C90", Offset = "0x71A0C90", VA = "0x1871A1C90", Slot = "16")]
	private PGHHFLOFLBF NMOOLFIBCCA(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x71A20C0", Offset = "0x71A10C0", VA = "0x1871A20C0", Slot = "17")]
	private IEOOEGFPLID MDJPFAFDAOJ(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x71A1B40", Offset = "0x71A0B40", VA = "0x1871A1B40", Slot = "18")]
	private GFGHHLGFFPG EGPGHALEDGN(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class BIFJJBJFHMJ : FDNGLPDCKHB, DNPNOKFCKLA
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public bool JNEKBGLIJCB
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x5D18190", Offset = "0x5D17190", VA = "0x185D18190", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x5D183D0", Offset = "0x5D173D0", VA = "0x185D183D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5D185A0", Offset = "0x5D175A0", VA = "0x185D185A0")]
	public BIFJJBJFHMJ(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5D18260", Offset = "0x5D17260", VA = "0x185D18260", Slot = "6")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x5D18360", Offset = "0x5D17360", VA = "0x185D18360", Slot = "7")]
	public void LNOPBHJDCOE(Rigidbody JHKHONGEEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal class FDNGLPDCKHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	protected readonly PICOGHEPFKI HAPBMPEEKBC;

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	protected HIOAPONHMCI POEPGBPJLGG
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DD30", Offset = "0x5D1CD30", VA = "0x185D1DD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	protected HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DD00", Offset = "0x5D1CD00", VA = "0x185D1DD00")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x5D185A0", Offset = "0x5D175A0", VA = "0x185D185A0")]
	public FDNGLPDCKHB(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DD50", Offset = "0x5D1CD50", VA = "0x185D1DD50")]
	protected GKIJIJOABOO JBMKINBHKJK(HKCCJJBDGFK IFPLGBGLLJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class GBJNLDAEJCC : FDNGLPDCKHB, IOJACBLDOHM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private PhotonView PKDKKABALLP;

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool ACONAACMEEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x5D23C70", Offset = "0x5D22C70", VA = "0x185D23C70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public bool DGEAHLNJGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x5D23C90", Offset = "0x5D22C90", VA = "0x185D23C90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400003F")]
	public event CPDMFGNNCLB KJGCJBOEFOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x5D23DB0", Offset = "0x5D22DB0", VA = "0x185D23DB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x5D24830", Offset = "0x5D23830", VA = "0x185D24830", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0x5D24A90", Offset = "0x5D23A90", VA = "0x185D24A90")]
	public GBJNLDAEJCC(GKIJIJOABOO HAPBMPEEKBC, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x5D24040", Offset = "0x5D23040", VA = "0x185D24040", Slot = "8")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x5D23E50", Offset = "0x5D22E50", VA = "0x185D23E50", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x5D24500", Offset = "0x5D23500", VA = "0x185D24500", Slot = "9")]
	public void GMEDKEJBENK(GKIJIJOABOO DJAGPEDCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x5D24190", Offset = "0x5D23190", VA = "0x185D24190", Slot = "10")]
	public void EFFAAHLOMDP(GKIJIJOABOO DJAGPEDCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x5D248D0", Offset = "0x5D238D0", VA = "0x185D248D0")]
	private void NMFFHLCDEOB(PhotonView HGCPILHMKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x5D24350", Offset = "0x5D23350", VA = "0x185D24350")]
	private void FMFDAKGODDJ(RigidbodyEx KAACFCLMIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x5D246C0", Offset = "0x5D236C0", VA = "0x185D246C0")]
	private void HDJMAKAMCIL(PhotonView LPFBDBNCJMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal static class KFINLFENGAK
{
	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x5D34410", Offset = "0x5D33410", VA = "0x185D34410")]
	public static GBJNLDAEJCC IGNAPAGMLPA(this JLDKEPCIJOL HBKAFCIHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal sealed class GNKGNABGKFB : FDNGLPDCKHB, GFGHHLGFFPG
{
	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public bool EKBGPCJPIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x5D28580", Offset = "0x5D27580", VA = "0x185D28580", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x5D28390", Offset = "0x5D27390", VA = "0x185D28390", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public bool NLFPLPANICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x5D28840", Offset = "0x5D27840", VA = "0x185D28840", Slot = "6")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x5D28750", Offset = "0x5D27750", VA = "0x185D28750")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public RigidbodyConstraints BHPHKBKMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x5D280B0", Offset = "0x5D270B0", VA = "0x185D280B0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x5D28180", Offset = "0x5D27180", VA = "0x185D28180", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x5D28910", Offset = "0x5D27910", VA = "0x185D28910")]
	public GNKGNABGKFB(GKIJIJOABOO HAPBMPEEKBC, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x5D28480", Offset = "0x5D27480", VA = "0x185D28480", Slot = "9")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x5D28650", Offset = "0x5D27650", VA = "0x185D28650", Slot = "10")]
	public void LNOPBHJDCOE(Rigidbody JHKHONGEEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class GAGDDMLCHKE : FDNGLPDCKHB, AALKHMIGOHM, IDisposable, ELBCOIDLJBC
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public FMOMJHKLCHF PHKIAKCBAMH
	{
		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x5D22C80", Offset = "0x5D21C80", VA = "0x185D22C80")]
		get
		{
			return default(FMOMJHKLCHF);
		}
		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x5D229D0", Offset = "0x5D219D0", VA = "0x185D229D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public FMOMJHKLCHF HGMPDKIENND
	{
		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x5D22AC0", Offset = "0x5D21AC0", VA = "0x185D22AC0", Slot = "6")]
		get
		{
			return default(FMOMJHKLCHF);
		}
		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x5D229D0", Offset = "0x5D219D0", VA = "0x185D229D0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	private Transform BJLCDGNLJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x867490", Offset = "0x866490", VA = "0x180867490", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000040")]
	public event Action<CDHDCBBOJLO, CDHDCBBOJLO> DAANECCDGFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x5D22D50", Offset = "0x5D21D50", VA = "0x185D22D50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x5D22DF0", Offset = "0x5D21DF0", VA = "0x185D22DF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x5D185A0", Offset = "0x5D175A0", VA = "0x185D185A0")]
	public GAGDDMLCHKE(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x5D22E90", Offset = "0x5D21E90", VA = "0x185D22E90", Slot = "11")]
	public void OnChangedDistanceBand(CDHDCBBOJLO BEKGPJHMFFJ, CDHDCBBOJLO HEIIEHCMKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "12")]
	public void OnChangedVisibility(bool GAOJOOJGIPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "8")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public sealed class LAEDAFGAIEK : AALKHMIGOHM, IDisposable, ELBCOIDLJBC
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public const int MKPNKCODMNN = 350;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private FMOMJHKLCHF OGLCHCOOEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private JLAJANPMJBM BGCLKJIBDHK;

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public FMOMJHKLCHF HGMPDKIENND
	{
		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D38E90", Offset = "0x5D37E90", VA = "0x185D38E90", Slot = "6")]
		get
		{
			return default(FMOMJHKLCHF);
		}
		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D38A60", Offset = "0x5D37A60", VA = "0x185D38A60", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	private Transform BJLCDGNLJIB
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D38B90", Offset = "0x5D37B90", VA = "0x185D38B90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000041")]
	public event Action<CDHDCBBOJLO, CDHDCBBOJLO> DAANECCDGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D38F80", Offset = "0x5D37F80", VA = "0x185D38F80", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D39020", Offset = "0x5D38020", VA = "0x185D39020", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D390C0", Offset = "0x5D380C0", VA = "0x185D390C0")]
	public LAEDAFGAIEK(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D38C00", Offset = "0x5D37C00", VA = "0x185D38C00", Slot = "8")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D38BB0", Offset = "0x5D37BB0", VA = "0x185D38BB0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D38B30", Offset = "0x5D37B30", VA = "0x185D38B30", Slot = "11")]
	private void BBLPEOJMANK(CDHDCBBOJLO GMDACNKJDGE, CDHDCBBOJLO NAMHKAOMNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "12")]
	private void LAJIBAIMJMN(bool GAOJOOJGIPC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
internal sealed class HCDHMCMMLJE : IGOBICCBPLE, IOJACBLDOHM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private PhotonView PKDKKABALLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private bool DBNJMJPKGNE;

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public PhotonView AMDCMHKAEED
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	public bool ACONAACMEEO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D23C70", Offset = "0x5D22C70", VA = "0x185D23C70", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	public bool DGEAHLNJGHA
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x967710", Offset = "0x966710", VA = "0x180967710", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000042")]
	public event CPDMFGNNCLB KJGCJBOEFOC
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x5D296B0", Offset = "0x5D286B0", VA = "0x185D296B0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A0E0", Offset = "0x5D290E0", VA = "0x185D2A0E0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A300", Offset = "0x5D29300", VA = "0x185D2A300")]
	public HCDHMCMMLJE(GKIJIJOABOO HAPBMPEEKBC, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D29860", Offset = "0x5D28860", VA = "0x185D29860", Slot = "9")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D29750", Offset = "0x5D28750", VA = "0x185D29750", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D29CC0", Offset = "0x5D28CC0", VA = "0x185D29CC0", Slot = "10")]
	public void GMEDKEJBENK(GKIJIJOABOO DJAGPEDCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D299B0", Offset = "0x5D289B0", VA = "0x185D299B0", Slot = "11")]
	public void EFFAAHLOMDP(GKIJIJOABOO DJAGPEDCGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A180", Offset = "0x5D29180", VA = "0x185D2A180")]
	private void NMFFHLCDEOB(PhotonView HGCPILHMKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D29B40", Offset = "0x5D28B40", VA = "0x185D29B40")]
	private void FMFDAKGODDJ(RigidbodyEx KAACFCLMIHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D29E50", Offset = "0x5D28E50", VA = "0x185D29E50")]
	private void HDJMAKAMCIL(PhotonView LPFBDBNCJMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class NADCPPNBCED
{
	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x719DEC0", Offset = "0x719CEC0", VA = "0x18719DEC0")]
	public static IGOBICCBPLE IGNAPAGMLPA(this GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
internal sealed class BIPONJIBNDA : NKPFENENCON
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private const string CMFMMDKEHCP = "RBEX_ANIM";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly FPCHIOCGOJB MLJOLBGFKIC;

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	public Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x913240", Offset = "0x912240", VA = "0x180913240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	private bool KHGGKLLFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x5D18A00", Offset = "0x5D17A00", VA = "0x185D18A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	public bool CJHHFDCHPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x17BFCD0", Offset = "0x17BECD0", VA = "0x1817BFCD0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D19670", Offset = "0x5D18670", VA = "0x185D19670")]
	public BIPONJIBNDA(GKIJIJOABOO HAPBMPEEKBC, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D18950", Offset = "0x5D17950", VA = "0x185D18950", Slot = "5")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0x5D19640", Offset = "0x5D18640", VA = "0x185D19640", Slot = "7")]
	public void PKCJDHEHHKF(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x5D19170", Offset = "0x5D18170", VA = "0x185D19170", Slot = "8")]
	public void MNPDLAIMCKF(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D18C60", Offset = "0x5D17C60", VA = "0x185D18C60", Slot = "9")]
	public void GBLJPONPLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D18A60", Offset = "0x5D17A60", VA = "0x185D18A60", Slot = "10")]
	public void FFCBJIOHPMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D18620", Offset = "0x5D17620", VA = "0x185D18620", Slot = "11")]
	public void ALFOHLKNOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D191A0", Offset = "0x5D181A0", VA = "0x185D191A0", Slot = "12")]
	public void NABHAJFKIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x5D187A0", Offset = "0x5D177A0", VA = "0x185D187A0")]
	private void CEMCAOCAGJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x5D18FC0", Offset = "0x5D17FC0", VA = "0x185D18FC0")]
	private void HAIABNGGBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal sealed class JBCDOENADCM : GFGHHLGFFPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private RigidbodyConstraints KNBENOGDALJ;

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	public bool EKBGPCJPIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xD760A0", Offset = "0xD750A0", VA = "0x180D760A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x21A5C90", Offset = "0x21A4C90", VA = "0x1821A5C90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	public bool NLFPLPANICC
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x24DC9B0", Offset = "0x24DB9B0", VA = "0x1824DC9B0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x24DC9A0", Offset = "0x24DB9A0", VA = "0x1824DC9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000146")]
	public RigidbodyConstraints BHPHKBKMLMB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x9AEAB0", Offset = "0x9ADAB0", VA = "0x1809AEAB0", Slot = "7")]
		get
		{
			return default(RigidbodyConstraints);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D2ABE0", Offset = "0x5D29BE0", VA = "0x185D2ABE0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AD80", Offset = "0x5D29D80", VA = "0x185D2AD80")]
	public JBCDOENADCM(GKIJIJOABOO HAPBMPEEKBC, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AD20", Offset = "0x5D29D20", VA = "0x185D2AD20", Slot = "9")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AD50", Offset = "0x5D29D50", VA = "0x185D2AD50", Slot = "10")]
	public void LNOPBHJDCOE(Rigidbody JHKHONGEEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
internal sealed class GBEFNNIECHO : FCIFCFBJPFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.Token(Token = "0x17000147")]
	private Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D19E60", Offset = "0x5D18E60", VA = "0x185D19E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	private bool HBNNMGOPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D19E10", Offset = "0x5D18E10", VA = "0x185D19E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	private bool KHGGKLLFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D18A00", Offset = "0x5D17A00", VA = "0x185D18A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	private GKIJIJOABOO HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D23170", Offset = "0x5D22170", VA = "0x185D23170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D23C30", Offset = "0x5D22C30", VA = "0x185D23C30")]
	public GBEFNNIECHO(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x5D23AD0", Offset = "0x5D22AD0", VA = "0x185D23AD0", Slot = "4")]
	public void PJCLLEGFFHE(Vector3 HNGHLFFJCGK, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x5D235D0", Offset = "0x5D225D0", VA = "0x185D235D0")]
	private void NNLAAGPKJCK(Vector3 HNGHLFFJCGK, ForceMode MJBIGEIBMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x5D231D0", Offset = "0x5D221D0", VA = "0x185D231D0", Slot = "5")]
	public void HJJLBECNANN(Vector3 HNGHLFFJCGK, Vector3 NKMKMKDMOMJ, ForceMode MJBIGEIBMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x5D23470", Offset = "0x5D22470", VA = "0x185D23470", Slot = "6")]
	public void LMJMOPPPAJB(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x5D23850", Offset = "0x5D22850", VA = "0x185D23850")]
	private void PGINFGJBNFK(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x5D22EF0", Offset = "0x5D21EF0", VA = "0x185D22EF0", Slot = "7")]
	public void BBEKPKFIJJP(Vector3 LHMFEONOCDO, ForceMode MJBIGEIBMGC = ForceMode.Force)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal sealed class DHBNEDCNGMD : OHCHLJICFCI, EPGNOJDAMLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly BNEKMLMKILB<GKIJIJOABOO> PLOCMPPHPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool IPBPBOLPDNA;

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	public BNEKMLMKILB<GKIJIJOABOO> POCMJLJGOBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	public Vector3 HBJLINEEDEP
	{
		[Cpp2IlInjected.Token(Token = "0x60004DF")]
		[Cpp2IlInjected.Address(RVA = "0x5D1CDC0", Offset = "0x5D1BDC0", VA = "0x185D1CDC0", Slot = "6")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	public Vector3 HPLGGDFELMA
	{
		[Cpp2IlInjected.Token(Token = "0x60004E0")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C5E0", Offset = "0x5D1B5E0", VA = "0x185D1C5E0", Slot = "7")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	private Vector3 CJHFGNNEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C7B0", Offset = "0x5D1B7B0", VA = "0x185D1C7B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	public GKIJIJOABOO JMAGIBIDIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C960", Offset = "0x5D1B960", VA = "0x185D1C960", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CDF0", Offset = "0x5D1BDF0", VA = "0x185D1CDF0")]
	public DHBNEDCNGMD(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C890", Offset = "0x5D1B890", VA = "0x185D1C890", Slot = "8")]
	public void JBLFGKCHBNP(GKIJIJOABOO DJAGPEDCGHG, object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C900", Offset = "0x5D1B900", VA = "0x185D1C900", Slot = "9")]
	public void JGFDPLBGHAE(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C2F0", Offset = "0x5D1B2F0", VA = "0x185D1C2F0")]
	private Vector3 DHFDDBMEDEF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CA10", Offset = "0x5D1BA10", VA = "0x185D1CA10")]
	private void MKEPPAIMLBK(GKIJIJOABOO MCDNJBKCGCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal static class CENDBLKOCDG
{
	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x5D1B870", Offset = "0x5D1A870", VA = "0x185D1B870")]
	public static OHCHLJICFCI CNMOIJBGJEI(this GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class GEALINJLHIF : MCJCEOMEFCD, IEOOEGFPLID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly OverridableVector3 NIIFGFIFLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly OverridableVector3 CCMGHKCLEIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private float FFCIDGEJFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private float LJJHDOLPJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Vector3 BHFJCPPNKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Vector3? PFLPIMMPEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Quaternion? LEBLIEFNHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool HOENINBJCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private bool DLPLCADJFOD;

	[Cpp2IlInjected.Token(Token = "0x17000150")]
	public Vector3 MJJEDHDHCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x27CBC40", Offset = "0x27CAC40", VA = "0x1827CBC40", Slot = "7")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x5D25E60", Offset = "0x5D24E60", VA = "0x185D25E60", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000151")]
	public Vector3 OMLCGNPLGJE
	{
		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x5D25130", Offset = "0x5D24130", VA = "0x185D25130", Slot = "9")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000152")]
	public float CCHBEOPHGCC
	{
		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x10B4E30", Offset = "0x10B3E30", VA = "0x1810B4E30", Slot = "10")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D24EF0", Offset = "0x5D23EF0", VA = "0x185D24EF0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000153")]
	public float HCPLDPOGKKL
	{
		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xC62FA0", Offset = "0xC61FA0", VA = "0x180C62FA0", Slot = "11")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D24E40", Offset = "0x5D23E40", VA = "0x185D24E40", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000154")]
	public Vector3 ENGONBLHLID
	{
		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x5D25AB0", Offset = "0x5D24AB0", VA = "0x185D25AB0", Slot = "13")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000155")]
	public Quaternion MGJBLPJDEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x5D24B20", Offset = "0x5D23B20", VA = "0x185D24B20", Slot = "14")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000156")]
	private Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D8D0", Offset = "0x5D1C8D0", VA = "0x185D1D8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000043")]
	public event CPDMFGNNCLB HNJACDDFBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x5D255F0", Offset = "0x5D245F0", VA = "0x185D255F0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x5D24DA0", Offset = "0x5D23DA0", VA = "0x185D24DA0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D274A0", Offset = "0x5D264A0", VA = "0x185D274A0")]
	public GEALINJLHIF(GKIJIJOABOO HAPBMPEEKBC, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D258E0", Offset = "0x5D248E0", VA = "0x185D258E0", Slot = "17")]
	public void MIGNLHGCABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D25010", Offset = "0x5D24010", VA = "0x185D25010", Slot = "16")]
	public void FPKLGKNCPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D253B0", Offset = "0x5D243B0", VA = "0x185D253B0", Slot = "19")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D25690", Offset = "0x5D24690", VA = "0x185D25690", Slot = "20")]
	public void LNOPBHJDCOE(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D25490", Offset = "0x5D24490", VA = "0x185D25490", Slot = "18")]
	public void LGLOKNEEAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D26FE0", Offset = "0x5D25FE0", VA = "0x185D26FE0", Slot = "21")]
	public void PMMIPEBHDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5D25E60", Offset = "0x5D24E60", VA = "0x185D25E60")]
	private void OKIKGCNEOFB(Vector3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D24C90", Offset = "0x5D23C90", VA = "0x185D24C90")]
	[Obsolete]
	private Vector3 CGAIJNLPNAD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D24EF0", Offset = "0x5D23EF0", VA = "0x185D24EF0")]
	private void FFELLMMKLBL(float CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D24E40", Offset = "0x5D23E40", VA = "0x185D24E40")]
	private void NCAEEIONACK(float CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x5D26E70", Offset = "0x5D25E70", VA = "0x185D26E70")]
	private Vector3 OOEJBKJJBEO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5D25C20", Offset = "0x5D24C20", VA = "0x185D25C20", Slot = "15")]
	public void NANHMOGKJKJ((Quaternion rot, Vector3 moments) DKHOIHPOENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0x5D25240", Offset = "0x5D24240", VA = "0x185D25240")]
	private Quaternion JGMJFLKGFMI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0x5D25F10", Offset = "0x5D24F10", VA = "0x185D25F10")]
	public void OLCKFEJDPHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0x5D25FF0", Offset = "0x5D24FF0", VA = "0x185D25FF0", Slot = "4")]
	public (float, Vector3) OLCKFEJDPHL(Rigidbody BBAOFCOHNND)
	{
		return default((float, Vector3));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal static class EAJPPIBFFHH
{
	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D000", Offset = "0x5D1C000", VA = "0x185D1D000")]
	public static MCJCEOMEFCD GLMNBFHIDJB(this GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface OHCHLJICFCI : EPGNOJDAMLC
{
	[Cpp2IlInjected.Token(Token = "0x17000157")]
	BNEKMLMKILB<GKIJIJOABOO> POCMJLJGOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000158")]
	GKIJIJOABOO JMAGIBIDIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class PEGGEIIEIJK : AKDKABCMEKE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly FPCHIOCGOJB MGEAFDEHNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private float MLCINDOKLHO;

	[Cpp2IlInjected.Token(Token = "0x17000159")]
	public FBBNGPOGPDF GDMLIKAFCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x9132B0", Offset = "0x9122B0", VA = "0x1809132B0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015A")]
	public PCCGNALJHJC IEFFEBPICJN
	{
		[Cpp2IlInjected.Token(Token = "0x600050A")]
		[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0xA8F810", Offset = "0xA8E810", VA = "0x180A8F810", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015B")]
	public Vector3 CJHFGNNEJMN
	{
		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x71A0730", Offset = "0x719F730", VA = "0x1871A0730", Slot = "8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x719F3F0", Offset = "0x719E3F0", VA = "0x18719F3F0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015C")]
	public Vector3 DBLBMIIKPPM
	{
		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x719F4B0", Offset = "0x719E4B0", VA = "0x18719F4B0", Slot = "10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x71A03F0", Offset = "0x719F3F0", VA = "0x1871A03F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015D")]
	public Vector3 HCEGPGILCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x71A0310", Offset = "0x719F310", VA = "0x1871A0310", Slot = "12")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x71A12B0", Offset = "0x71A02B0", VA = "0x1871A12B0", Slot = "13")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015E")]
	public Vector3 BHGOINLEFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x71A11F0", Offset = "0x71A01F0", VA = "0x1871A11F0", Slot = "14")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x719F3C0", Offset = "0x719E3C0", VA = "0x18719F3C0", Slot = "15")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700015F")]
	public float PBKPBDBPLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0xFF9AE0", Offset = "0xFF8AE0", VA = "0x180FF9AE0", Slot = "16")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x71A0950", Offset = "0x719F950", VA = "0x1871A0950", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000160")]
	public bool ICIMBBIGOLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0xA66950", Offset = "0xA65950", VA = "0x180A66950", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000161")]
	private FCIFCFBJPFF DPEMCCDKENE
	{
		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x22D3310", Offset = "0x22D2310", VA = "0x1822D3310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000162")]
	private bool NIECADIBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x5D1AF50", Offset = "0x5D19F50", VA = "0x185D1AF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x71A16C0", Offset = "0x71A06C0", VA = "0x1871A16C0")]
	public PEGGEIIEIJK(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0x719F5D0", Offset = "0x719E5D0", VA = "0x18719F5D0", Slot = "19")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0x719F570", Offset = "0x719E570", VA = "0x18719F570", Slot = "37")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x71A0B00", Offset = "0x719FB00", VA = "0x1871A0B00", Slot = "28")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0xA436E0", Offset = "0xA426E0", VA = "0x180A436E0", Slot = "20")]
	public void JCHDKKLHDLC(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0xA41A20", Offset = "0xA40A20", VA = "0x180A41A20", Slot = "31")]
	public void LOJJDJMIBDL(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x71A0ED0", Offset = "0x719FED0", VA = "0x1871A0ED0", Slot = "36")]
	public Vector3 MBJCIOAOPLA(Vector3 JIBAOMFGMOP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0x71A0810", Offset = "0x719F810", VA = "0x1871A0810", Slot = "35")]
	public Vector3 IPGPGFJKEGH(Vector3 BEGLMLACECH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0x719F5D0", Offset = "0x719E5D0", VA = "0x18719F5D0", Slot = "27")]
	public void OBOCHBKOAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x719FC70", Offset = "0x719EC70", VA = "0x18719FC70", Slot = "25")]
	public void FJIMPNLFGOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x71A1040", Offset = "0x71A0040", VA = "0x1871A1040", Slot = "24")]
	public void MLMACKBHHDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0x719F220", Offset = "0x719E220", VA = "0x18719F220", Slot = "34")]
	public void CIJCEOHOIFH(Vector3 HKJCBCHFCPK, Vector3 IKOKBFBENAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x71A1370", Offset = "0x71A0370", VA = "0x1871A1370", Slot = "33")]
	public void NNONEIIDODB(Vector3 HLEKEMPNOFO, Vector3 HALOBGHOELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x719FCB0", Offset = "0x719ECB0", VA = "0x18719FCB0", Slot = "32")]
	public void GNHFMHHHPJP(Vector3 GLHHKKHDPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0x719F7C0", Offset = "0x719E7C0", VA = "0x18719F7C0", Slot = "22")]
	public void FHIGAJBINGD(ICCDFEDDHBO PPEJEAKNDAO, Vector3 CINGCIOKEJN, float LOILAGEIMBB, float PBCAKBEJADJ = 8f, float KLJFGNKNFHH = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0x71A13D0", Offset = "0x71A03D0", VA = "0x1871A13D0", Slot = "21")]
	public void NPMAPGEAPOM(HKBPFCIHPDB AGONOFKHJKP, Vector3 MMCFJBKAPNO, float LPIFLMOBAEB = float.PositiveInfinity)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x71A0BD0", Offset = "0x719FBD0", VA = "0x1871A0BD0", Slot = "23")]
	[Obsolete]
	public void LCMNPPLAMEK(HKBPFCIHPDB AGONOFKHJKP, Vector3 NMKLOHCPMNL, float ABJOHFIBNNH = 7f, float LIPCNPEMHDI = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x719ED70", Offset = "0x719DD70", VA = "0x18719ED70", Slot = "30")]
	public Vector3 BABHBPECAMD(Vector3 DIGLJLOIALF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x719F120", Offset = "0x719E120", VA = "0x18719F120", Slot = "29")]
	public Vector3 BPDJEMCGEHA(Vector3 BFOCKHBKDDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0x71A0A10", Offset = "0x719FA10", VA = "0x1871A0A10", Slot = "26")]
	public void JOICJIPFNHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x71A0950", Offset = "0x719F950", VA = "0x1871A0950")]
	private void IPOMEKCHAEE(float CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x71A1080", Offset = "0x71A0080", VA = "0x1871A1080")]
	private void MMLFBOLBGFO(Vector3 MMCFJBKAPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x719F700", Offset = "0x719E700", VA = "0x18719F700")]
	private Vector3 FEBKPGFKPFI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x719EE30", Offset = "0x719DE30", VA = "0x18719EE30")]
	private void BKKGANEMFBP(Vector3 BEGLMLACECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x71A1600", Offset = "0x71A0600", VA = "0x1871A1600")]
	private Vector3 PIFCIBMMDHL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0x71A0420", Offset = "0x719F420", VA = "0x1871A0420")]
	private void IABEFBMKNFC(Vector3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0x719FE20", Offset = "0x719EE20", VA = "0x18719FE20")]
	private void GPCKNDNMFAL(Vector3 BEGLMLACECH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0x719F640", Offset = "0x719E640", VA = "0x18719F640")]
	private void EIEAKDOGBLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class NHOPBDABBLL : COLFKEAIKIE
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private const string JKCBDGCPKOB = "IsKinematicByDefault";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FPCHIOCGOJB LACPAHJKDDG;

	[Cpp2IlInjected.Token(Token = "0x17000163")]
	public bool HBNNMGOPLDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x719E340", Offset = "0x719D340", VA = "0x18719E340", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000164")]
	public IEnumerable<object> NKMCCLFKAIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000538")]
		[Cpp2IlInjected.Address(RVA = "0x719E470", Offset = "0x719D470", VA = "0x18719E470", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000044")]
	public event CPDMFGNNCLB JBJICGHHDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x719E1B0", Offset = "0x719D1B0", VA = "0x18719E1B0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x719E2A0", Offset = "0x719D2A0", VA = "0x18719E2A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x719E4C0", Offset = "0x719D4C0", VA = "0x18719E4C0")]
	public NHOPBDABBLL(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x719E050", Offset = "0x719D050", VA = "0x18719E050", Slot = "12")]
	public IDisposable GACBMNJIACD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x719E460", Offset = "0x719D460", VA = "0x18719E460", Slot = "9")]
	public void KAELNCJCGFP(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x719E250", Offset = "0x719D250", VA = "0x18719E250", Slot = "10")]
	public void HOCNFCJLBPG(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x719E0B0", Offset = "0x719D0B0", VA = "0x18719E0B0", Slot = "11")]
	public void GKJKMFOOEAJ(object FFKJLIDBALM, bool JODHJMHBHKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x719E260", Offset = "0x719D260", VA = "0x18719E260", Slot = "6")]
	public void IPKMBAHFCID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x719E3E0", Offset = "0x719D3E0", VA = "0x18719E3E0", Slot = "13")]
	public void JPPEJFNNKOF(Rigidbody CIEJBNMPJKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x719E490", Offset = "0x719D490", VA = "0x18719E490", Slot = "14")]
	public void LNOPBHJDCOE(Rigidbody JHKHONGEEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal sealed class MDDAHNCCGAF : KCLMAFFCLOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private CollisionDetectionMode OGCJCPNOCIC;

	[Cpp2IlInjected.Token(Token = "0x17000165")]
	private Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x719C7A0", Offset = "0x719B7A0", VA = "0x18719C7A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000166")]
	public CollisionDetectionMode CFPICLDPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x719C6A0", Offset = "0x719B6A0", VA = "0x18719C6A0", Slot = "4")]
		get
		{
			return default(CollisionDetectionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x719C760", Offset = "0x719B760", VA = "0x18719C760", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x719C920", Offset = "0x719B920", VA = "0x18719C920")]
	public MDDAHNCCGAF(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x719C520", Offset = "0x719B520", VA = "0x18719C520", Slot = "6")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x719C7C0", Offset = "0x719B7C0", VA = "0x18719C7C0", Slot = "9")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0x719C750", Offset = "0x719B750", VA = "0x18719C750", Slot = "7")]
	public void HMCOBLAMCNB(bool DCBEHDNEFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0x719C910", Offset = "0x719B910", VA = "0x18719C910", Slot = "8")]
	public void OKAEEFDELAJ(bool DCBEHDNEFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0x719C810", Offset = "0x719B810", VA = "0x18719C810", Slot = "10")]
	public bool KDILDFBMPIF(Vector3 HCEFOMOBPKF, out RaycastHit CGLNBILMEGG, float FJDPGBJBEDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x719C5D0", Offset = "0x719B5D0", VA = "0x18719C5D0")]
	private void EHPIMPPJBEO(bool DCBEHDNEFPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public class JHMFAANNEFM : KDBIAHFONJN
{
	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B9C0", Offset = "0x5D2A9C0", VA = "0x185D2B9C0", Slot = "4")]
	public HNNBMDLKLHB OGBHICJOKHL(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B890", Offset = "0x5D2A890", VA = "0x185D2B890", Slot = "5")]
	public AKDKABCMEKE NANJCOFPMIJ(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B8F0", Offset = "0x5D2A8F0", VA = "0x185D2B8F0", Slot = "6")]
	public EPGNOJDAMLC NJEEJAHAMHC(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B640", Offset = "0x5D2A640", VA = "0x185D2B640", Slot = "7")]
	public EOEFLBEIKKI LCGLDAEIICG(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B6B0", Offset = "0x5D2A6B0", VA = "0x185D2B6B0", Slot = "8")]
	public PKIFEAFNLDP LDIKLAKHKJI(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B740", Offset = "0x5D2A740", VA = "0x185D2B740", Slot = "9")]
	public AALKHMIGOHM LKNBBLKOCDK(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B220", Offset = "0x5D2A220", VA = "0x185D2B220", Slot = "10")]
	public COLFKEAIKIE DJBBMFHFDGM(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B140", Offset = "0x5D2A140", VA = "0x185D2B140", Slot = "11")]
	public FCIFCFBJPFF BOCAPHJPMGD(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B3F0", Offset = "0x5D2A3F0", VA = "0x185D2B3F0", Slot = "12")]
	public KCLMAFFCLOC FHOHPFBKKPC(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B1B0", Offset = "0x5D2A1B0", VA = "0x185D2B1B0", Slot = "13")]
	public DNPNOKFCKLA CDHFFHIJPAO(GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B280", Offset = "0x5D2A280", VA = "0x185D2B280")]
	public NKPFENENCON GPLNLPNFGLB(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B0B0", Offset = "0x5D2A0B0", VA = "0x185D2B0B0")]
	public IOJACBLDOHM BGLAILFIDDF(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B450", Offset = "0x5D2A450", VA = "0x185D2B450")]
	public PGHHFLOFLBF FJGPAKPMDJL(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B7B0", Offset = "0x5D2A7B0", VA = "0x185D2B7B0")]
	public IEOOEGFPLID MHDNBLBJAIO(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B360", Offset = "0x5D2A360", VA = "0x185D2B360")]
	public GFGHHLGFFPG GDIPABKDHBG(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B520", Offset = "0x5D2A520", VA = "0x185D2B520", Slot = "19")]
	public GKIJIJOABOO JEBPGNPPFJB(RigidbodyEx HAPBMPEEKBC, IMBADAJGPJF HHCEHFFEAKN, JAKOFGLBKHL ALPIPCHDOEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public JHMFAANNEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B280", Offset = "0x5D2A280", VA = "0x185D2B280", Slot = "14")]
	private NKPFENENCON DPHCLCDGBJE(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B0B0", Offset = "0x5D2A0B0", VA = "0x185D2B0B0", Slot = "15")]
	private IOJACBLDOHM KBFMIFJFFEJ(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B450", Offset = "0x5D2A450", VA = "0x185D2B450", Slot = "16")]
	private PGHHFLOFLBF NMOOLFIBCCA(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B7B0", Offset = "0x5D2A7B0", VA = "0x185D2B7B0", Slot = "17")]
	private IEOOEGFPLID MDJPFAFDAOJ(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B360", Offset = "0x5D2A360", VA = "0x185D2B360", Slot = "18")]
	private GFGHHLGFFPG EGPGHALEDGN(GKIJIJOABOO HBKAFCIHEAM, in IMBADAJGPJF HHCEHFFEAKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class LCHINEICCFN : AJDDPMODGKA, HNNBMDLKLHB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly GKIJIJOABOO HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<GKIJIJOABOO> IIBLLLMNGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private GKIJIJOABOO EMIPEAKIENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private GKIJIJOABOO DJAGPEDCGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Transform FLAKPHHFOGM;

	[Cpp2IlInjected.Token(Token = "0x17000167")]
	private Transform CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x5D39530", Offset = "0x5D38530", VA = "0x185D39530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000168")]
	public GKIJIJOABOO HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000576")]
		[Cpp2IlInjected.Address(RVA = "0x9AD4B0", Offset = "0x9AC4B0", VA = "0x1809AD4B0", Slot = "28")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A410", Offset = "0x5D39410", VA = "0x185D3A410", Slot = "29")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000169")]
	public GKIJIJOABOO LGIBJPCGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x992280", Offset = "0x991280", VA = "0x180992280", Slot = "27")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016A")]
	public IReadOnlyList<GKIJIJOABOO> HCCPLAHGKNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x97E5B0", Offset = "0x97D5B0", VA = "0x18097E5B0", Slot = "26")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000045")]
	public event CPDMFGNNCLB LCHFLBDEBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A600", Offset = "0x5D39600", VA = "0x185D3A600", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x5D39100", Offset = "0x5D38100", VA = "0x185D39100", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000046")]
	public event CPDMFGNNCLB OFOJPGDJBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A190", Offset = "0x5D39190", VA = "0x185D3A190", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A4C0", Offset = "0x5D394C0", VA = "0x185D3A4C0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000047")]
	public event DCOPMFBIBNC GAJMBFEEBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A230", Offset = "0x5D39230", VA = "0x185D3A230", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x5D39C80", Offset = "0x5D38C80", VA = "0x185D39C80", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000048")]
	public event Action JDHEPKFGNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x5D39BE0", Offset = "0x5D38BE0", VA = "0x185D39BE0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x5D396B0", Offset = "0x5D386B0", VA = "0x185D396B0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000049")]
	public event Action HHMCDAKEEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x5D3ACD0", Offset = "0x5D39CD0", VA = "0x185D3ACD0", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x5D3AC30", Offset = "0x5D39C30", VA = "0x185D3AC30", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004A")]
	public event Action<GKIJIJOABOO> AMMFMNEEOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A420", Offset = "0x5D39420", VA = "0x185D3A420", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A050", Offset = "0x5D39050", VA = "0x185D3A050", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004B")]
	public event Action<GKIJIJOABOO> NKLGELOFNCG
	{
		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A0F0", Offset = "0x5D390F0", VA = "0x185D3A0F0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x5D39FB0", Offset = "0x5D38FB0", VA = "0x185D39FB0", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004C")]
	public event Action MNMELFCLPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A560", Offset = "0x5D39560", VA = "0x185D3A560", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x5D39B40", Offset = "0x5D38B40", VA = "0x185D39B40", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004D")]
	public event Action<GKIJIJOABOO> CEGKOKMJALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x5D39610", Offset = "0x5D38610", VA = "0x185D39610", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x5D3A370", Offset = "0x5D39370", VA = "0x185D3A370", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x5D3AD70", Offset = "0x5D39D70", VA = "0x185D3AD70")]
	public LCHINEICCFN(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x5D39590", Offset = "0x5D38590", VA = "0x185D39590", Slot = "31")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0x5D3A6A0", Offset = "0x5D396A0", VA = "0x185D3A6A0", Slot = "30")]
	public void PELENMOAPPI(GKIJIJOABOO GFJHNOHABFL, bool KPNOPNBLPDN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0x5D39930", Offset = "0x5D38930", VA = "0x185D39930", Slot = "6")]
	public void FMLGHJBFLJE(GKIJIJOABOO BPJPHGOLFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x5D391E0", Offset = "0x5D381E0", VA = "0x185D391E0", Slot = "7")]
	public void DILOLFLPDFN(GKIJIJOABOO BPJPHGOLFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x5D3A2D0", Offset = "0x5D392D0", VA = "0x185D3A2D0", Slot = "4")]
	public void MDHEGCDPHGI(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x5D39DE0", Offset = "0x5D38DE0", VA = "0x185D39DE0", Slot = "5")]
	public void HIJNKPPMGLM(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x5D39750", Offset = "0x5D38750", VA = "0x185D39750")]
	private void FDBGLBAJPAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x5D391A0", Offset = "0x5D381A0", VA = "0x185D391A0")]
	private void ANGOBBCBGEI(GKIJIJOABOO BPJPHGOLFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x5D397E0", Offset = "0x5D387E0", VA = "0x185D397E0")]
	private void FGHIBPNNKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x5D39E80", Offset = "0x5D38E80", VA = "0x185D39E80")]
	private void JJMLJFCKNKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x5D39400", Offset = "0x5D38400", VA = "0x185D39400")]
	private void DNAPNCOAJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x5D39D20", Offset = "0x5D38D20", VA = "0x185D39D20")]
	[CompilerGenerated]
	private object HCDJGGLHLBH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class DNINPFOOMPF
{
	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x5D1CF80", Offset = "0x5D1BF80", VA = "0x185D1CF80")]
	public static AJDDPMODGKA NJDJFHLCGOF(this GKIJIJOABOO HBKAFCIHEAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class AHDPMHNFODN : PGHHFLOFLBF
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private const string MMLCDACPJAK = "INTERP_PAUSE";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly FPCHIOCGOJB PJBAHHNKHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly FLACBGLBMKA ACKBLPKDHMI;

	[Cpp2IlInjected.Token(Token = "0x1700016B")]
	public bool ADLCDDONGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000586")]
		[Cpp2IlInjected.Address(RVA = "0x17BFCD0", Offset = "0x17BECD0", VA = "0x1817BFCD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016C")]
	public FLACBGLBMKA CKAGLECBIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0xBB0410", Offset = "0xBAF410", VA = "0x180BB0410", Slot = "5")]
		get
		{
			return default(FLACBGLBMKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x5D180F0", Offset = "0x5D170F0", VA = "0x185D180F0")]
	public AHDPMHNFODN(GKIJIJOABOO HAPBMPEEKBC, in IMBADAJGPJF HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x5D17CE0", Offset = "0x5D16CE0", VA = "0x185D17CE0", Slot = "6")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x5D17C10", Offset = "0x5D16C10", VA = "0x185D17C10")]
	private bool BJPNJAJHCAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x5D18080", Offset = "0x5D17080", VA = "0x185D18080", Slot = "7")]
	public void HNEHOALDMKJ(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x5D17CB0", Offset = "0x5D16CB0", VA = "0x185D17CB0", Slot = "8")]
	public void CHDOAHKLOJM(object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x5D17AE0", Offset = "0x5D16AE0", VA = "0x185D17AE0", Slot = "11")]
	public void BCFHKCJHAAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x5D17F30", Offset = "0x5D16F30", VA = "0x185D17F30")]
	private void FOFDBOFCKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x5D17DB0", Offset = "0x5D16DB0", VA = "0x185D17DB0")]
	private void EFEGAMFCMOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x5D180B0", Offset = "0x5D170B0", VA = "0x185D180B0", Slot = "10")]
	public void NMLFHJHIDFH(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x5D18040", Offset = "0x5D17040", VA = "0x185D18040", Slot = "9")]
	public void HCBFOLLPIFP(GKIJIJOABOO HAPBMPEEKBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface MCJCEOMEFCD : IEOOEGFPLID
{
	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(Slot = "0")]
	(float, Vector3) OLCKFEJDPHL(Rigidbody BBAOFCOHNND);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public interface AJDDPMODGKA : HNNBMDLKLHB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDHEGCDPHGI(GKIJIJOABOO HAPBMPEEKBC);

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIJNKPPMGLM(GKIJIJOABOO HAPBMPEEKBC);

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FMLGHJBFLJE(GKIJIJOABOO BPJPHGOLFCL);

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DILOLFLPDFN(GKIJIJOABOO BPJPHGOLFCL);
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal sealed class LFKNEOEELPC : DNPNOKFCKLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool AKFHBEDNOMA;

	[Cpp2IlInjected.Token(Token = "0x1700016D")]
	public bool JNEKBGLIJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x85F3D0", Offset = "0x85E3D0", VA = "0x18085F3D0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x5D3AE60", Offset = "0x5D39E60", VA = "0x185D3AE60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x5D3AF70", Offset = "0x5D39F70", VA = "0x185D3AF70")]
	public LFKNEOEELPC(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x5D3AE30", Offset = "0x5D39E30", VA = "0x185D3AE30", Slot = "6")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x5D18360", Offset = "0x5D17360", VA = "0x185D18360", Slot = "7")]
	public void LNOPBHJDCOE(Rigidbody JHKHONGEEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class EDEJFBMEEPA : PKIFEAFNLDP
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private const int JLALFMANINA = 10;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private const float ABBIPMGAIGG = 9E-05f;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private const float BHDPBNIKPLJ = 0.0001f;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private const float CDCBFPINPFE = 5f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly JLDKEPCIJOL HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private bool LOKKFBHAKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool GKNCIJLBMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private int LJFFGMJKBEO;

	[Cpp2IlInjected.Token(Token = "0x1700016E")]
	private Rigidbody IIPBJHLJBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D8D0", Offset = "0x5D1C8D0", VA = "0x185D1D8D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700016F")]
	private bool JHJJMGPLNLN
	{
		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DB50", Offset = "0x5D1CB50", VA = "0x185D1DB50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000170")]
	private bool NIECADIBGIO
	{
		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D7B0", Offset = "0x5D1C7B0", VA = "0x185D1D7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000171")]
	private GKIJIJOABOO HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D7D0", Offset = "0x5D1C7D0", VA = "0x185D1D7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000172")]
	private bool KHGGKLLFNPE
	{
		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D500", Offset = "0x5D1C500", VA = "0x185D1D500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400004E")]
	public event CPDMFGNNCLB AALLMMHBBEK
	{
		[Cpp2IlInjected.Token(Token = "0x600059C")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DBF0", Offset = "0x5D1CBF0", VA = "0x185D1DBF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D920", Offset = "0x5D1C920", VA = "0x185D1D920", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DCA0", Offset = "0x5D1CCA0", VA = "0x185D1DCA0")]
	public EDEJFBMEEPA(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D460", Offset = "0x5D1C460", VA = "0x185D1D460", Slot = "6")]
	public void ECJGBFOOMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0x5D1DC90", Offset = "0x5D1CC90", VA = "0x185D1DC90", Slot = "8")]
	public void PMKDOCIKNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D300", Offset = "0x5D1C300", VA = "0x185D1D300", Slot = "7")]
	public bool BOKGHGDFDOI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D830", Offset = "0x5D1C830", VA = "0x185D1D830", Slot = "9")]
	public void JCCAKBLBCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D560", Offset = "0x5D1C560", VA = "0x185D1D560", Slot = "11")]
	public void FMOBJOLKMGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D100", Offset = "0x5D1C100", VA = "0x185D1D100", Slot = "12")]
	public void ADKDLIBNMCE(bool FGLGAHABBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D600", Offset = "0x5D1C600", VA = "0x185D1D600", Slot = "10")]
	public void GEEAFJLCCHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D140", Offset = "0x5D1C140", VA = "0x185D1D140")]
	private bool BDLLHMNOABH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D1D9C0", Offset = "0x5D1C9C0", VA = "0x185D1D9C0")]
	private void MKHMCBLNGMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class LNKHHLBNIHH : EOEFLBEIKKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly GKIJIJOABOO HAPBMPEEKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private float DFGAJEGDAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private float LAOKCKEIHIM;

	[Cpp2IlInjected.Token(Token = "0x17000173")]
	public float DEGADDEAHMN
	{
		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0xA76E90", Offset = "0xA75E90", VA = "0x180A76E90", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x5D3B170", Offset = "0x5D3A170", VA = "0x185D3B170", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000174")]
	public float IEHKIAHDHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0xA76E80", Offset = "0xA75E80", VA = "0x180A76E80", Slot = "6")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D3AFB0", Offset = "0x5D39FB0", VA = "0x185D3AFB0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x5D3B240", Offset = "0x5D3A240", VA = "0x185D3B240")]
	public LNKHHLBNIHH(GKIJIJOABOO HAPBMPEEKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D3B080", Offset = "0x5D3A080", VA = "0x185D3B080", Slot = "8")]
	public void JPPEJFNNKOF(Rigidbody JHKHONGEEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D3B0D0", Offset = "0x5D3A0D0", VA = "0x185D3B0D0", Slot = "9")]
	public void LNOPBHJDCOE(Rigidbody JHKHONGEEFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public interface IGOBICCBPLE : IOJACBLDOHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000175")]
	PhotonView AMDCMHKAEED
	{
		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RRAssemblyIndex.RecRoom.Rbex.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[global::RecRoom.CodeGen.Attributes.Preserve]
	internal class _RRAssemblyIndex : AINCPJMNCKB
	{
		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x86EBE0", Offset = "0x86DBE0", VA = "0x18086EBE0")]
		[global::RecRoom.CodeGen.Attributes.Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x71A8470", Offset = "0x71A7470", VA = "0x1871A8470", Slot = "6")]
		public sealed override void GKPMAKNFHGI(NBHPPJJIFEO ELHFOIEJAFO)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
