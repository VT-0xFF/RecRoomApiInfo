using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Photon.Pun;
using RecRoom.Core.Creation;
using RecRoom.Logging.Attributes;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Maker_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : MKCMLEJGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6938820", Offset = "0x6937A20", VA = "0x186938820", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class ConfigurableSubpiece : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private Collider[] colliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Renderer[] hoverRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public IEBCNEDNECP<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IEAMIDCGINA HIJBBPHGBIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x85A6C0", VA = "0x18085B4C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] ANPGHLCCPJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] OKLGICAEGJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<IEAMIDCGINA> LNPLMKJMMDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6934680", Offset = "0x6933880", VA = "0x186934680")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6934730", Offset = "0x6933930", VA = "0x186934730")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6934310", Offset = "0x6933510", VA = "0x186934310")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69343C0", Offset = "0x69335C0", VA = "0x1869343C0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6934430", Offset = "0x6933630", VA = "0x186934430")]
		public void SetIConfigurable(IEAMIDCGINA HDCCONPCDEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6934320", Offset = "0x6933520", VA = "0x186934320")]
		public void ChangeCollidersAndRenderers(Collider[] GBBBENGNIMP, Renderer[] KNHDDMPHJEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6934560", Offset = "0x6933760", VA = "0x186934560")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6934410", Offset = "0x6933610", VA = "0x186934410")]
		public void RunConfigurationSpecialActions(IEAMIDCGINA EDEFIMKFJIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69345F0", Offset = "0x69337F0", VA = "0x1869345F0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LFCJNMAJOKM
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BMIHDIHLACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object EOCJCEFCOOA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object EOCJCEFCOOA);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OOIJHCCAAKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece GGOBCJIFOPM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece GGOBCJIFOPM);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider LKIKJGEBEHP);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FMPAFLNKBKP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject BGONLCODLBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid NLFEGNPLCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string KHJLONLFPLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string ONIPGMFPPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 EPEMKAANOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 PCKAHHMDECP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion KHCNENJLHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion ACLOFDCFLFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float JDLKEDGCFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float DLMMKBPCBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 IGDKJAGFOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 BJHBGLGBAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool LAAGMPPEEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IEAMIDCGINA HIJBBPHGBIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	[CanBeNull]
	DJGICDAKCOK HEIOJKCFCLL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JCNAPFFAJJJ;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 ABNKNLJOCPH, float ADNFOGCFPIG, float JBGBECDDBCH);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 ABNKNLJOCPH, float ADNFOGCFPIG, bool DPGDEJJAHGF, Space EKLPOPINKNL);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider LKIKJGEBEHP);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface CILFHBLDFOO
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool EHOBIGFDJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool JLMCEDMALNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 DBLEJOGONCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 CGFDBGLKILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EBCFDIHJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool BNJBLMANPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PEPJOAOPMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool PEDEHLCLCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool HJKEKKCGNKL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool BMPILLADOAC
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool ELGCINFEDIC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnDeformed(Vector3 KKMKNCFCIFG);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnHoverStart(LCIMADDMNJK EBDNEHAMLPD, Collider LKJCLDJFADD, KBLFKPAIPCA HLBENBAELID);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(LCIMADDMNJK EBDNEHAMLPD, Collider LKJCLDJFADD);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(LCIMADDMNJK EBDNEHAMLPD, GABGGJOAGAC NGJGFJKCICN, KBLFKPAIPCA.NBDIPGBPAMH BNMIBFMKNNG);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Translate(Vector3 GHBIOLAPBDK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Rotate(Quaternion BOHAJHHOLIC);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool Scale(float BONLJCBABLI);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface MFFNGENHDEC
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JDGLBJCEAPH([In] Vector3 MNCFLKFGCKD, [In] Vector3 FCBGHELDCII, Vector3 MHAPFDBLKOP, Vector3 NFFLDAHKGKD);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GDGFOKCDONF
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool IJLFBIHLLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	MJPOGCFKFFN FNPLPPLGEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MasterDespawn();

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MCDNMAKBNFN
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool DNNCNOOIPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	ENDFCAJOOEH MCKOFGMBFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> PPFCJMOAICL;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int MHDBELHLAGE);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NBJOLOJLFIH GetCulprit(MBPHFKAHBDA CNIGHIFKPGF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FCKEFJAGLIM
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	IEnumerable<IOCBPGJKGPA.IDIKNJJDJKJ> PHBDOPPPNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(IOCBPGJKGPA.IDIKNJJDJKJ CFNKOEDDPAI);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(IOCBPGJKGPA.IDIKNJJDJKJ CFNKOEDDPAI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OGNNKOMANGL
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void Reset();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PDNJAHFANPF
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LBKCAJKDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool FEDPJOKCFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JFILMLBCMDL
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	int MLGMPIOGLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(DLNBBOCFFAG? IJOMIOBDNPE);

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(BCGPGMMDBCL? AHGKEHOFKKH);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "5")]
	MBPHFKAHBDA CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LBHDPJBCLFA
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool IELMFOPGLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool GJLMCDEODNI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool IHJEOFCHEMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MFPJAOOHGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool FMNMCOEJDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool MDNGIHPCEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool PFFGKHNNEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	IEnumerable<Collider> IEMALFBEELE
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MJMBINKCMII? DBLKAHKLIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool IIJODKCIHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool BGKJFEPCEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CostInfo GetSandboxResourceCost(bool KCPKHMNMPKP = true);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DJPPDEEBCCL
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MBPHFKAHBDA CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 HGDCPNGLIKJ, [Out] Quaternion LCDJINCAHMD, [Out] float NGAMAICEFKI, [Out] Vector3 BFNOEPPMPNP);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? HGDCPNGLIKJ, Quaternion? LCDJINCAHMD, float? NGAMAICEFKI, Vector3? BFNOEPPMPNP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OBFDKPGBEKB
{
	[Cpp2IlInjected.Token(Token = "0x17000032")]
	object KAPPHBDIJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Type LLGBDDEOAFB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	Guid HIMAFKINCNI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface IEAMIDCGINA
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IReadOnlyList<EIAJMFOKGPL> FDPDNMMIKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string ONIPGMFPPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	string GMAAIIDGDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool OONANGMADII
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> OMHFGOPFMNE;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<IEAMIDCGINA> NNJIMIHOLIK;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<BLKGOGELFBB, NPEMONFLKNM> OLPJMNJBIGN;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JKOHLHMKNDK;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ICPAIPBGMNF
{
	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool FAOFGFPAJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public struct IOCBPGJKGPA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate JMEIDFKMOML IDIKNJJDJKJ();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<IDIKNJJDJKJ> FFOLPCNLOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<IDIKNJJDJKJ> ODJAHOCBECC;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public IEnumerable<IDIKNJJDJKJ> DPOODIHMHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6936D60", Offset = "0x6935F60", VA = "0x186936D60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6936E20", Offset = "0x6936020", VA = "0x186936E20")]
	public void PBLNBBGFGAP(IDIKNJJDJKJ CFNKOEDDPAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6936DC0", Offset = "0x6935FC0", VA = "0x186936DC0")]
	public bool MFKDEBIIBOM(IDIKNJJDJKJ CFNKOEDDPAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum JMEIDFKMOML
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface DJGICDAKCOK
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool HGFFOGKHCCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "1")]
	[CanBeNull]
	PCPBEKLLPEH IENDHJOHANB();

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "2")]
	[CanBeNull]
	GOOOOJHFJDH OINGHJKBOJK();

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GHLEEIFPKLL(Guid OMMMJLCIKCB, long NEALIGNIMIO, int FNBGNLBNJAF, bool DENOPCKCNKN);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GHLEEIFPKLL(DJGICDAKCOK OKGBBGMIACH);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NAIBDOGECIC(LOLBALEJJPK LINJEFIAFHO);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface PCPBEKLLPEH : PHGKJCNINOE
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	static readonly long NMDHMDFNNAM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	static readonly int LBIEALBNLMH;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	static readonly Guid JEIFNONNKON;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Guid MGCPLEGFCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	long NHBBMMIFBJM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	[Obsolete("This is not used - version tracking is done at the server level as collections of InventionId")]
	int JODMKGBCFEO
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x69388B0", Offset = "0x6937AB0", VA = "0x1869388B0")]
	static PCPBEKLLPEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[Obsolete("This is not used by anything and does not give us full provenance tracking")]
public interface GOOOOJHFJDH
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	[Obsolete("This is not currently consumed and does not give us full provenance tracking, however it does contain information that may prevent 'contamination' of invention contents by other non-monetizable inventions")]
	bool DPOKHOGCHJN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface PHGKJCNINOE
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	bool GLOIHGIFIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	[CanBeNull]
	FADKIJMOGML OHNAAHOINGA();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLMOJNLLLKA(NBJOLOJLFIH LMHOJCOKABB);

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCJLNANFIAK();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface FADKIJMOGML
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	int DLLOMOCMMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	int NOJCACPLEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JOHHDHJNILB : DJGICDAKCOK, PCPBEKLLPEH, PHGKJCNINOE, FADKIJMOGML, GOOOOJHFJDH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private MBJGDLLKJGA<Guid, ObscuredLong, ObscuredInt, ObscuredBool> HOCMCJBFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MDCOPDMECOF<ObscuredBool, ObscuredInt, ObscuredInt> MAOCJFHICIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private MonoBehaviourPun IDOOJPJNKLC;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Guid MGCPLEGFCJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6937670", Offset = "0x6936870", VA = "0x186937670")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private long NHBBMMIFBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x69377A0", Offset = "0x69369A0", VA = "0x1869377A0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private int JODMKGBCFEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6937130", Offset = "0x6936330", VA = "0x186937130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private bool DPOKHOGCHJN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69373B0", Offset = "0x69365B0", VA = "0x1869373B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private bool GLOIHGIFIFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6937F70", Offset = "0x6937170", VA = "0x186937F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private int NOJCACPLEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69375E0", Offset = "0x69367E0", VA = "0x1869375E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private int DLLOMOCMMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69380F0", Offset = "0x69372F0", VA = "0x1869380F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool HGFFOGKHCCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x6937D70", Offset = "0x6936F70", VA = "0x186937D70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	private Guid PHCJGPEINFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6937670", Offset = "0x6936870", VA = "0x186937670", Slot = "10")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	private long BLMGHJKKLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6937E20", Offset = "0x6937020", VA = "0x186937E20", Slot = "11")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private int MGNGIANGEGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6937840", Offset = "0x6936A40", VA = "0x186937840", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private int EDICAJBABDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x69375E0", Offset = "0x69367E0", VA = "0x1869375E0", Slot = "18")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	private int PCALOGBBLCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x69380F0", Offset = "0x69372F0", VA = "0x1869380F0", Slot = "17")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private bool GEKFACALCEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6938030", Offset = "0x6937230", VA = "0x186938030", Slot = "19")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private bool EAGBFOHANIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6938180", Offset = "0x6937380", VA = "0x186938180", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6938220", Offset = "0x6937420", VA = "0x186938220")]
	public JOHHDHJNILB(MonoBehaviourPun NFLAKCGICLM, string ANJMOCOMAJH, Guid CNJDNKBGJAG, long NEALIGNIMIO, int FNBGNLBNJAF, bool DENOPCKCNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x69371C0", Offset = "0x69363C0", VA = "0x1869371C0", Slot = "20")]
	public void BHHCONGNEPE(LOLBALEJJPK LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6938040", Offset = "0x6937240", VA = "0x186938040", Slot = "9")]
	public void NAIBDOGECIC(LOLBALEJJPK LINJEFIAFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x69376E0", Offset = "0x69368E0", VA = "0x1869376E0")]
	public static LOLBALEJJPK EAOFNKAFLHJ(Guid CNJDNKBGJAG, long NEALIGNIMIO, int ENHJCHEDLND, bool DENOPCKCNKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6937E30", Offset = "0x6937030", VA = "0x186937E30", Slot = "5")]
	public PCPBEKLLPEH IENDHJOHANB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6937E30", Offset = "0x6937030", VA = "0x186937E30", Slot = "6")]
	public GOOOOJHFJDH OINGHJKBOJK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6937850", Offset = "0x6936A50", VA = "0x186937850", Slot = "7")]
	public void GHLEEIFPKLL(Guid OMMMJLCIKCB, long NEALIGNIMIO, int FNBGNLBNJAF, bool DENOPCKCNKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6937A20", Offset = "0x6936C20", VA = "0x186937A20", Slot = "8")]
	public void GHLEEIFPKLL(DJGICDAKCOK DNAFGBHPPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6938000", Offset = "0x6937200", VA = "0x186938000", Slot = "14")]
	private FADKIJMOGML MNGPAPGPKGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6937440", Offset = "0x6936640", VA = "0x186937440", Slot = "15")]
	private void COOCNKIJCJB(NBJOLOJLFIH LMHOJCOKABB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6937E60", Offset = "0x6937060", VA = "0x186937E60", Slot = "16")]
	private void JOAKDNOLDNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct KBLFKPAIPCA : IEquatable<KBLFKPAIPCA>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DHNJCHAEOMJ : FJGCBIBHNKC<KBLFKPAIPCA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool CFHDDGLKNCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x69348C0", Offset = "0x6933AC0", VA = "0x1869348C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x69347E0", Offset = "0x69339E0", VA = "0x1869347E0")]
		public bool AJNBHLBIOCH(GABGGJOAGAC JHCDKNMGDJN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6934900", Offset = "0x6933B00", VA = "0x186934900")]
		public KBLFKPAIPCA JGIFJINDHGH(GABGGJOAGAC JHCDKNMGDJN)
		{
			return default(KBLFKPAIPCA);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6934800", Offset = "0x6933A00", VA = "0x186934800")]
		private int BKEGLGKIBNF(GABGGJOAGAC JHCDKNMGDJN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x69349C0", Offset = "0x6933BC0", VA = "0x1869349C0")]
		public DHNJCHAEOMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public enum KGPALKNMPDF
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		UgcGameplaySystem,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		ContentCreationTool,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		PlayerDirectInteraction,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		HackStandinPriorityToDistinguishNone
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum NBDIPGBPAMH
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		TARGETED_OBJECT,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		ALL_UNDER_ROOT_CONNECTABLE
	}

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static readonly KBLFKPAIPCA JHJHHIDHPNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly KGPALKNMPDF CLMJDMFGEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly GABGGJOAGAC DONPFIBABNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public readonly NBDIPGBPAMH FFLGFNAAOHN;

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6938810", Offset = "0x6937A10", VA = "0x186938810")]
	public KBLFKPAIPCA(GABGGJOAGAC JHCDKNMGDJN, KGPALKNMPDF CBHPEKJLLAF = KGPALKNMPDF.UgcGameplaySystem, NBDIPGBPAMH DNCAOAEPAKK = NBDIPGBPAMH.TARGETED_OBJECT)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6938750", Offset = "0x6937950", VA = "0x186938750")]
	public static bool KBKLEFBHIDJ(KBLFKPAIPCA MLFGLJKBOIG, KBLFKPAIPCA GANEOONFJPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6938620", Offset = "0x6937820", VA = "0x186938620", Slot = "4")]
	public bool Equals(KBLFKPAIPCA OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6938560", Offset = "0x6937760", VA = "0x186938560", Slot = "0")]
	public override bool Equals(object MEAFIMADMKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x69386D0", Offset = "0x69378D0", VA = "0x1869386D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OOGPOJEAMCD
{
	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RequestStartOutlining(KBLFKPAIPCA GPCNCGBOPJG);

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RequestStopOutlining(GABGGJOAGAC JHCDKNMGDJN, KBLFKPAIPCA.NBDIPGBPAMH DNCAOAEPAKK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public abstract class FMGAPOFOMCP
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static ODIOBOMGOFD<Vector3> HGOJPPFHIOK;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public static ODIOBOMGOFD<Vector3> KMOPMPBCBJG;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6934A90", Offset = "0x6933C90", VA = "0x186934A90", Slot = "4")]
	protected virtual void JAGFBEFCBME(Vector3 FEPEBBANBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6934A00", Offset = "0x6933C00", VA = "0x186934A00", Slot = "5")]
	protected virtual void IGNNANLNIOH(Vector3 FEPEBBANBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	protected FMGAPOFOMCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal class JMICNCJJLHB : FMGAPOFOMCP
{
	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x6937080", Offset = "0x6936280", VA = "0x186937080")]
	public void MJEKIBAJFGL(Vector3 HGDCPNGLIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x69370B0", Offset = "0x69362B0", VA = "0x1869370B0")]
	public void PEOLBHNNNMI(Vector3 HGDCPNGLIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x69370E0", Offset = "0x69362E0", VA = "0x1869370E0")]
	public JMICNCJJLHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IMLJGLLEGIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static ProfilerMarker NBDEKKOCPAA;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static ProfilerMarker PKBEFELLHNG;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static readonly string ICEGGDKJCGN;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly string JGNLENGGICF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly int[] ELCCJHLCPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly int[] BOGBJHFJNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private GameObject KDCMDFJBDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private MeshCollider FGMOIBNPMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private GameObject MCPMBCCANLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private MeshFilter NFNKMBBCDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private Mesh GCOPCGGBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private Mesh NGNMKOMDCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private Collider[] CAKELOLKJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private List<Collider> LNFBNNABGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Vector3[] IEANAFHCNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private Vector3 BDBOMDGHLFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Vector3 CCODBKLOLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private Quaternion FNLEICAANEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private Vector3[] OILFBBEEMBC;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	private Mesh EBKKJAFBOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x855CB0", VA = "0x180856AB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6936130", Offset = "0x6935330", VA = "0x186936130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	private Mesh EEAMJPBEDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x855BD0", VA = "0x1808569D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6936720", Offset = "0x6935920", VA = "0x186936720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	private int PBHHLOECNDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6935130", Offset = "0x6934330", VA = "0x186935130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public IEnumerable<Collider> EGGFCNKMMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6935150", Offset = "0x6934350", VA = "0x186935150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6936890", Offset = "0x6935A90", VA = "0x186936890")]
	public IMLJGLLEGIP(Material BPKHGFNPDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6934F10", Offset = "0x6934110", VA = "0x186934F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6936680", Offset = "0x6935880", VA = "0x186936680")]
	public void ODPFCHPEIML(Vector2 HAHBLJHLEGJ, Vector2 MCPOFCOEDBH, Camera OKGPIGCMLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6935870", Offset = "0x6934A70", VA = "0x186935870")]
	public void JNFFMLBHFGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6935160", Offset = "0x6934360", VA = "0x186935160")]
	private IEnumerable<Collider> HJAKCAPEJPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6935720", Offset = "0x6934920", VA = "0x186935720")]
	private void HKJHBPECPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6934FD0", Offset = "0x69341D0", VA = "0x186934FD0")]
	private void EBACIIMGPPH(Material GIIKGEKINDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6936290", Offset = "0x6935490", VA = "0x186936290")]
	private void NAHKOAOFCLE(Vector2 HAHBLJHLEGJ, Vector2 MCPOFCOEDBH, Camera OKGPIGCMLDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69358B0", Offset = "0x6934AB0", VA = "0x1869358B0")]
	private void KKIMOCKJLGC(Vector2 HAHBLJHLEGJ, Vector2 MCPOFCOEDBH, Camera OKGPIGCMLDO, Vector2 MIKFFHLMFMG, Vector2 DPAANEOENFI, Vector3 LFLBFEPDECH, Vector3 DFGDBMBBNFC, Vector3 FHFJADDADOM, Vector3 FFMGABGDKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6936180", Offset = "0x6935380", VA = "0x186936180")]
	private void KOCOMKFMMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x6934C10", Offset = "0x6933E10", VA = "0x186934C10")]
	private void CKIKBGBIAFL(Vector3 MHFEANFINOK, Vector3 LFLBFEPDECH, Vector3 DFGDBMBBNFC, Vector3 FHFJADDADOM, Vector3 FFMGABGDKKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x69361F0", Offset = "0x69353F0", VA = "0x1869361F0")]
	private void MJJAIDAIDHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EPHINMPOKBC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private OBKGCADPMOG<T> DKCKLFMCODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NHFPGGGGADD<T> BIFMNCLOIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private List<T> CKKPJPPPFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private List<T> OIOLLJJGBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private List<T> HOIFCCLFIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private List<T> OBCGLGCKMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private List<T> KIIGJDFHPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private List<T> KBOBIADPPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private PMJPJFBBBDC DNCAOAEPAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private JMICNCJJLHB FKEKNFGCMKH;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x381DE60", Offset = "0x381D060", VA = "0x18381DE60")]
	public EPHINMPOKBC(OBKGCADPMOG<T> DKCKLFMCODE, NHFPGGGGADD<T> BIFMNCLOIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x381DAA0", Offset = "0x381CCA0", VA = "0x18381DAA0")]
	public void PGKLFDNLGPL(PMJPJFBBBDC DNCAOAEPAKK = PMJPJFBBBDC.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x381C8A0", Offset = "0x381BAA0", VA = "0x18381C8A0")]
	public void NOADJHDAEBM(IEnumerable<Collider> GCIHBFAIGPJ, Vector3 ECKJHALECKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x381B750", Offset = "0x381A950", VA = "0x18381B750")]
	public bool LCENFNDIJHE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x381D9F0", Offset = "0x381CBF0", VA = "0x18381D9F0")]
	[CompilerGenerated]
	private bool NOOBIDOIAGP(T IPBJLCONKPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x381B6F0", Offset = "0x381A8F0", VA = "0x18381B6F0")]
	[CompilerGenerated]
	private bool DBBCAEEHEON(T IPBJLCONKPC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum PMJPJFBBBDC
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	Remove
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
