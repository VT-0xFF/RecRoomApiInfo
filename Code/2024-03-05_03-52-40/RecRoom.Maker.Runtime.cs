using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Core.Creation;
using Unity.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
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
		public KJAEILIDEKD<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HOKDFNBANIH PKMOEELFLPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] IJJAMGAJNHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] LKHPGGBDMHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<HOKDFNBANIH> GEODNGIJIGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6120A00", Offset = "0x611F800", VA = "0x186120A00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6120AB0", Offset = "0x611F8B0", VA = "0x186120AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6120690", Offset = "0x611F490", VA = "0x186120690")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6120740", Offset = "0x611F540", VA = "0x186120740")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61207B0", Offset = "0x611F5B0", VA = "0x1861207B0")]
		public void SetIConfigurable(HOKDFNBANIH PFPIJPIBMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61206A0", Offset = "0x611F4A0", VA = "0x1861206A0")]
		public void ChangeCollidersAndRenderers(Collider[] FLONGNFOIDO, Renderer[] JPAMLEBMENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61208E0", Offset = "0x611F6E0", VA = "0x1861208E0")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6120790", Offset = "0x611F590", VA = "0x186120790")]
		public void RunConfigurationSpecialActions(HOKDFNBANIH EIPPHKNAMED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6120970", Offset = "0x611F770", VA = "0x186120970")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EJJLODIFCFH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KJPLOAPFFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object BNAJMHPOOCG);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object BNAJMHPOOCG);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BHBPFCHKNPF
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece NKFODEJECOL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece NKFODEJECOL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider CNCBABNOLDD);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MPPCAOIJMGK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject EFKMFEFIIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid EBAGDBNKJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string PAHJIBDDKIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string BOBDJLDFIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 FMPGPGNHBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 IECMJKODHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion NAMNFFMILMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion GACOHGOGNDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float OJOPHILOEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float ELCMGEHFOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 LDOCIKOKIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 PFDEAEBMLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool INEGFOONNFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	HOKDFNBANIH PKMOEELFLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	NPIDHMFNJMM KBINAAGIKKH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MBEOFAGAKPH;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 PPMBNLPKFPN, float FPAODGHNLCA, float CDAGLJGPJJI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 PPMBNLPKFPN, float FPAODGHNLCA, bool HCIDJOCCGEF, Space LEJLNLKEBNK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider CNCBABNOLDD);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ICHOIIKMGFH
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool NKFLBDAKDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool DIKFIKBJEAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 JDMMBBBALOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 JHGJLPCLHMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool EIHCDPHJJEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OIGBJDEMKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool KJANDOLFKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool JGMMCMKKIMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool EMHIODIMBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GEJLDNFENCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnDeformed(Vector3 EFCNFIOBAJA);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnHoverStart(HJMBPJKAKAA NOKGACCEMBE, Collider EJEBELEOKLK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(HJMBPJKAKAA NOKGACCEMBE, Collider EJEBELEOKLK);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(HJMBPJKAKAA NOKGACCEMBE);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Translate(Vector3 CODOPKBAJDP);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Rotate(Quaternion FPFHKLDOABN);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool Scale(float JMABOANLGPK);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HCJFIFFEPKH
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OLCDDCCJOLK([In] Vector3 CDHDMAIICDB, [In] Vector3 JMFPDJFKFGP, Vector3 MEMBLPAFCDL, Vector3 BKELBBDDNIG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface FOBICLGBGNL
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool NKNEKNLNGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	IGJOIAOJFFC LOGCCOOAGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MasterDespawn();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LNJKGMHDHAK
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FJOFEOCMNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	JFEFKPEHDJK BLFELACPMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> LPHCCNPNKEA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int GKINMMAOIHP);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ABCJFLHLGDE GetCulprit(AMCICLANCPL BCAPONENNDF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FPEJAENLIKI
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<OPPNGHLNAJN.BOPLCNEAFII> LHPDMMLIHBO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(OPPNGHLNAJN.BOPLCNEAFII JONIJHBHDAH);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(OPPNGHLNAJN.BOPLCNEAFII JONIJHBHDAH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AIDPDELJDEF
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AFPLIODCCLN
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool FAIBHDBBIJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LAGIDGOGPEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GONLDCDHFDC
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int KOFADMBNHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(EEDFDLJFDEM? CAJANEDDNHG);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(DPIIANELJKL? KJMILHHGBID);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AMCICLANCPL CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface GIJLCBMKMNE
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool NPIIAFOENJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CostInfo PFPCBFONKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool DKFNMOIFBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool BBJJLGIEIKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool KADFMDMKBEG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool AAAMLMJGNFO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool NJJEHPMLMNC
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IEnumerable<Collider> CNGJDCKJCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	ALENJPKJFIP? KIFHFGJMPFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool EPMBBGBCBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool OLFOEMCFENL
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GDHPCJADAPH
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AMCICLANCPL CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 AJFNKFFNDBD, [Out] Quaternion OKEJHHGCFPM, [Out] float CACAABOCOLD, [Out] Vector3 KCPEOGCHCIM);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? AJFNKFFNDBD, Quaternion? OKEJHHGCFPM, float? CACAABOCOLD, Vector3? KCPEOGCHCIM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface BOOCHLJKICC
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	object NAEODIDPHEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Type MDEFHODGFLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Guid FLHACINMACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface HOKDFNBANIH
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IReadOnlyList<BLABBCNNLEL> KGCCBHJOKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string BOBDJLDFIIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string EOFPEBEFGHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool ADIMDPHMPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> FBGJEHIEEAK;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<HOKDFNBANIH> AGKNNDEMEIH;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<JOCBEIHIJHG, OOEKJOABGHI> HJAOONJFKNB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action GLBKKHAHOKK;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OICBALMDMDI
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool EGOONOLPHHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct OPPNGHLNAJN
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate KNOINNBAMEK BOPLCNEAFII();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<BOPLCNEAFII> EFGAIIPJOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<BOPLCNEAFII> ABGIKOOJCAG;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IEnumerable<BOPLCNEAFII> BEPGLPKAALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6121CA0", Offset = "0x6120AA0", VA = "0x186121CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6121AF0", Offset = "0x61208F0", VA = "0x186121AF0")]
	public void GALNLGNAACN(BOPLCNEAFII JONIJHBHDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6121A90", Offset = "0x6120890", VA = "0x186121A90")]
	public bool FIJOKOAGLFM(BOPLCNEAFII JONIJHBHDAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum KNOINNBAMEK
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NPIDHMFNJMM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int JHIKLILCLCA = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long AGNBHFIOEGN = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private FPMEBPINJFI<Guid, ObscuredLong, ObscuredInt, ObscuredBool> JDCDLCCCHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private DCAIGPAIABH<ObscuredBool, ObscuredInt, ObscuredInt> HBKMJODBOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun CMIMEIFNPKJ;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid MKLEJDAGGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6121200", Offset = "0x6120000", VA = "0x186121200")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public long KFFGKAPAKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6121500", Offset = "0x6120300", VA = "0x186121500")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int KGOHLPBDJCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x61216C0", Offset = "0x61204C0", VA = "0x1861216C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool HOBKHIMCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6120E70", Offset = "0x611FC70", VA = "0x186120E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool MOCHNJIBBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6121170", Offset = "0x611FF70", VA = "0x186121170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int BDCPEHEJJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x61215A0", Offset = "0x61203A0", VA = "0x1861215A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int OLDONDHPLLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6121630", Offset = "0x6120430", VA = "0x186121630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool MLMMBHCHOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6120F70", Offset = "0x611FD70", VA = "0x186120F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6121750", Offset = "0x6120550", VA = "0x186121750")]
	public NPIDHMFNJMM(MonoBehaviourPun AAFCGAIEFNH, string DHFDAJCFJCG, Guid NEHJMPBJOMB, long NEGFNKAMMJL, int CCHCAMNDAEH, bool PEMMJIBAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6120C10", Offset = "0x611FA10", VA = "0x186120C10")]
	public void BGHGCDKKNOK(ABCJFLHLGDE DBEGBPIBADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6121060", Offset = "0x611FE60", VA = "0x186121060")]
	public void DKGNPGOGPIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6121270", Offset = "0x6120070", VA = "0x186121270")]
	public void KCJBJGBIMAI(Guid KLNPICAKKNL, long NEGFNKAMMJL, int CCHCAMNDAEH, bool PEMMJIBAGIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6121430", Offset = "0x6120230", VA = "0x186121430")]
	public void KCJBJGBIMAI(NPIDHMFNJMM EDOEJIMPOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6120F00", Offset = "0x611FD00", VA = "0x186120F00")]
	public void CCKGEHENBEI(DDMJKHAPCLF EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6120FB0", Offset = "0x611FDB0", VA = "0x186120FB0")]
	public void CNIBAJEICFA(DDMJKHAPCLF EEDANCJJEPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6120DB0", Offset = "0x611FBB0", VA = "0x186120DB0")]
	public static DDMJKHAPCLF BLIGKMFCHEI(Guid NEHJMPBJOMB, long NEGFNKAMMJL, int LFLIDFKEJKM, bool PEMMJIBAGIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class CHFMBBKHEFK
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static AIHFEFKAOFF<Vector3> CHKCGMBKHNH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static AIHFEFKAOFF<Vector3> HIGHMDFLOPO;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6120480", Offset = "0x611F280", VA = "0x186120480", Slot = "4")]
	protected virtual void KBKLMLLIKLO(Vector3 PEMNEJENBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6120510", Offset = "0x611F310", VA = "0x186120510", Slot = "5")]
	protected virtual void LHPPAOBLFMK(Vector3 PEMNEJENBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	protected CHFMBBKHEFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal class NOJHBMMKPCL : CHFMBBKHEFK
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6120B90", Offset = "0x611F990", VA = "0x186120B90")]
	public void MPPIIMINOEK(Vector3 AJFNKFFNDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6120B60", Offset = "0x611F960", VA = "0x186120B60")]
	public void EDNKFDKCNEP(Vector3 AJFNKFFNDBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6120BC0", Offset = "0x611F9C0", VA = "0x186120BC0")]
	public NOJHBMMKPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CGFKOAFFKJI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static ProfilerMarker HMPJBNGEIEP;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static ProfilerMarker GIBDBODGFJE;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly string EONHFNDNFEE;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly string DBEICKBIFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly int[] HOCLFAJEIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly int[] KDDEFMBBNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GameObject JALLMCEEGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MeshCollider LLPDEKMFLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private GameObject NAJKCDIGLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MeshFilter OBLEGEHGGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Mesh DJOAGPKFODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Mesh GNNCNLDABGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Collider[] OMNDABAFJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private List<Collider> EBAFDCOMKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Vector3[] BKMEOHAGDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Vector3 KDIKFMDEACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Vector3 KOEKBHHFHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Quaternion OCICLDDKPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Vector3[] LCOHMFPBONG;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Mesh ELKOAAIPOPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B40", Offset = "0x7B7940", VA = "0x1807B8B40")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x611EB40", Offset = "0x611D940", VA = "0x18611EB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Mesh NCAKAJGIGME
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB70", Offset = "0x7BD970", VA = "0x1807BEB70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x611E8F0", Offset = "0x611D6F0", VA = "0x18611E8F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private int JIEPNPOKHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x611F9E0", Offset = "0x611E7E0", VA = "0x18611F9E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IEnumerable<Collider> FBKEBEMEBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x611F9D0", Offset = "0x611E7D0", VA = "0x18611F9D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x611FFB0", Offset = "0x611EDB0", VA = "0x18611FFB0")]
	public CGFKOAFFKJI(Material FJGGAMKNIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x611E530", Offset = "0x611D330", VA = "0x18611E530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x611FA00", Offset = "0x611E800", VA = "0x18611FA00")]
	public void NEPEIHPPNDF(Vector2 NMMGKKGNDFD, Vector2 AAOCLDJLBHD, Camera JMAPMJOABDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x611E330", Offset = "0x611D130", VA = "0x18611E330")]
	public void AGMOAPCJAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x611F410", Offset = "0x611E210", VA = "0x18611F410")]
	private IEnumerable<Collider> KJHPCFDJECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x611E370", Offset = "0x611D170", VA = "0x18611E370")]
	private void BODCOOENAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x611E9E0", Offset = "0x611D7E0", VA = "0x18611E9E0")]
	private void GGLFPBLOHNN(Material NLKDDMHEDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x611FAA0", Offset = "0x611E8A0", VA = "0x18611FAA0")]
	private void PMOPOKCHNFF(Vector2 NMMGKKGNDFD, Vector2 AAOCLDJLBHD, Camera JMAPMJOABDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x611EB90", Offset = "0x611D990", VA = "0x18611EB90")]
	private void JCEKCBCLMMO(Vector2 NMMGKKGNDFD, Vector2 AAOCLDJLBHD, Camera JMAPMJOABDH, Vector2 FGAPAFBFMBC, Vector2 NEFAIOBGGKF, Vector3 ANELOEEEEPD, Vector3 GLOJAOIFECA, Vector3 IFALGNOFGFA, Vector3 OGKPCHKMEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x611E4C0", Offset = "0x611D2C0", VA = "0x18611E4C0")]
	private void DILHHMEFEND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x611E5F0", Offset = "0x611D3F0", VA = "0x18611E5F0")]
	private void GCPNFBDIJBJ(Vector3 POLPFOAGDME, Vector3 ANELOEEEEPD, Vector3 GLOJAOIFECA, Vector3 IFALGNOFGFA, Vector3 OGKPCHKMEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x611E940", Offset = "0x611D740", VA = "0x18611E940")]
	private void GDKFNEPBKMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BMIJGCHJADG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private FCCEPFDIMFE<T> CIFGKBDGEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MKPMHACPPDJ<T> CAGMMCLIHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<T> ECNOKMMFDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<T> LMEOGMIDNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<T> LJEHLKMDIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<T> GOEHGPLBEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<T> ABIKNLMBCHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<T> NKCMHDAKKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MMADPNBFIII DEFFIHPLIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NOJHBMMKPCL NGCKPNBPBOL;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x47D8900", Offset = "0x47D7700", VA = "0x1847D8900")]
	public BMIJGCHJADG(FCCEPFDIMFE<T> CIFGKBDGEHC, MKPMHACPPDJ<T> CAGMMCLIHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x47D83F0", Offset = "0x47D71F0", VA = "0x1847D83F0")]
	public void FPLLGBFFFEM(MMADPNBFIII DEFFIHPLIBJ = MMADPNBFIII.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x47D6490", Offset = "0x47D5290", VA = "0x1847D6490")]
	public void EFIKJFNGFBK(IEnumerable<Collider> AJDCLBAAEKI, Vector3 JIMNOCMAEFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x47D85E0", Offset = "0x47D73E0", VA = "0x1847D85E0")]
	public bool LFJHLLMMOAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x47D8550", Offset = "0x47D7350", VA = "0x1847D8550")]
	[CompilerGenerated]
	private bool IOBEJCBOJMD(T BJKAJHEJDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x47D8500", Offset = "0x47D7300", VA = "0x1847D8500")]
	[CompilerGenerated]
	private bool IFCMBADPHBP(T BJKAJHEJDMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum MMADPNBFIII
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
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
