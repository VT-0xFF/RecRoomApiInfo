using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Mono.Math;
using Photon.Pun;
using RecRoom.Core.Creation;
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
		public global::HPEJKBNJDLG<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EGHCAHAGENK MFFGMGPGLDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x81B670", Offset = "0x81AA70", VA = "0x18081B670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] JIEGHMHEPOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] EELBOMLOFNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<EGHCAHAGENK> DFIKOAKCDOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x64E4F70", Offset = "0x64E4370", VA = "0x1864E4F70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x64E5010", Offset = "0x64E4410", VA = "0x1864E5010")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x64E4BB0", Offset = "0x64E3FB0", VA = "0x1864E4BB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x64E4C70", Offset = "0x64E4070", VA = "0x1864E4C70")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x64E4D20", Offset = "0x64E4120", VA = "0x1864E4D20")]
		public void SetIConfigurable(EGHCAHAGENK OMIMAFHPOKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x64E4BC0", Offset = "0x64E3FC0", VA = "0x1864E4BC0")]
		public void ChangeCollidersAndRenderers(Collider[] LLLBAADFAFA, Renderer[] AMLPOCIIKDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x64E4E60", Offset = "0x64E4260", VA = "0x1864E4E60")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64E4CD0", Offset = "0x64E40D0", VA = "0x1864E4CD0")]
		public void RunConfigurationSpecialActions(EGHCAHAGENK JGCPBKPKNLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x64E4EF0", Offset = "0x64E42F0", VA = "0x1864E4EF0")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CONHMLOPIHK
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PACAJEIGDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LIINCOFAKDD;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AddIsAnimated(object JCHAGIDHJIB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void RemoveIsAnimated(object JCHAGIDHJIB);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OGGGJNOBLJB
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece FJIDAMJOFAN);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece FJIDAMJOFAN);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider ECFBGBALBNM);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MAIEJEDAADD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject BNDGKEGJNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid BKDNHOGFJJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string LJDFOHKOPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string AJEIKKBELOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 GABFGMFOOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 MHKILGKADHG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion JLHJOCIFNIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion MIIEKLEEEMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float EDFAOBJKHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "15")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float NFPKDNBCCEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 LLBCFCLKNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 LOKMIMDEBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool HPMJLAOGGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool CIKJHPANCHB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	EGHCAHAGENK MFFGMGPGLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OHJKGHLKIEI JAEEGJIOJNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action GBMLIEGEHPK;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool CanUpdateDeformation(Vector3 DCFPOMAHMMK, float GDALFJCJHMN, float BKDMANCPHLE);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void UpdateDeformation(Vector3 DCFPOMAHMMK, float GDALFJCJHMN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool CanBeRaycasted(Collider ECFBGBALBNM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FJIGJGLKAEH
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NHLLKJAGGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool BHCNPCJKKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 BPOICHNHNKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Vector3 INNJKBNDIPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HOPFCJLONPO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GLPHCGHMLBO
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool HGJFOEJOFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool NDEACAKKFPA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool APFNDINEKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool MECOBMALKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnMoveStart();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnDeformed(Vector3 LCFNGOICBCM);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnMoveFinished();

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverStart(MIANMOJAFHE KAEDMDFLINB, Collider LBABKFDBKDG);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OnHovering(MIANMOJAFHE KAEDMDFLINB, Collider LBABKFDBKDG);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void OnHoverFinished(MIANMOJAFHE KAEDMDFLINB);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void Translate(Vector3 ABJEFOHKFJL);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void Rotate(Quaternion LNPHIGCIMIH);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool Scale(float PAGNPNMCLDG);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "33")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OIGKLKLMIHP
{
	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KEJAJFGPAGM(in Vector3 NOKNCIPGLOJ, in Vector3 GPCLDFNJCPC, ref Vector3 MOCLHJNGJBD, ref Vector3 FGGPFFJEFOG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HDOLOPOCCHC
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	DIIDNNFFODO BGKEMBFFIEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface HEAGEJMPFOG
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool IPOMAEOAJCL
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	IKJCNJLFDCD GDDLBIFBKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> BBIDJLEACJE;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int EECFAEEFJNK);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HIJGKEDACDC GetCulprit(GFJNIDDODPP NLNIGPKPICC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MADLDOPCFFE
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<PNMNMMNJJFM.GEPGKLJKMOE> KDAEDMAHMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(PNMNMMNJJFM.GEPGKLJKMOE LMCBIJMLGKM);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(PNMNMMNJJFM.GEPGKLJKMOE LMCBIJMLGKM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IGHLLFGAENP
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CanModifyProperty(string MLBMAJEOEBG);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LKBMPFOBGLB
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int KGLHPPFFFLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(GNACOFDONPN? AOFMPHFJGPF);

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(DCLGFICIGHE? DBOMLKOOKNG);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GFJNIDDODPP CanBeSelected();

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CanBeSelected(out GFJNIDDODPP CGKNIAMFPAO, out HIJGKEDACDC EGIHMCGAFEN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface LHFJBFNMKIO
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool LFKOPHBICAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	CostInfo BDOOOCMGOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool FDOGBDGFNFB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool HOFMGIJJBOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool AGENJPMAIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CHNNCNKJGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool CGPNDPONAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool LPCNFKALKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool FOHMJGNEBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IEnumerable<Collider> MCJHLKFBJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BoxCollider KPKLNECPGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool KJMPBNDHNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EMLCMJAJOEM
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GFJNIDDODPP CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo(out Vector3 KGJPEGOHADA, out Quaternion GCFIGFMOIAL, out float HGHMGIPKCAO, out Vector3 BKMPDNMODKN);

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? KGJPEGOHADA, Quaternion? GCFIGFMOIAL, float? HGHMGIPKCAO, Vector3? BKMPDNMODKN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ABNPCGECCOM
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	object DDIBIIAIOKG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	Type LBBOLPIEAGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Guid AKFELMPLMEK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EGHCAHAGENK
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	IReadOnlyList<MHJMCBCJFAE> LBMNBHHKJMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	string AJEIKKBELOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string IBCJGIBAFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	bool NFDBEOJPGBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<string> HGMOIGHIPCJ;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<EGHCAHAGENK> PMJGCBPLDFA;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action<JHGNDCIIILP, DCFMHGDPLIL> NHMEADMNILP;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action CIOGKKGADKO;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface EGJDFFBLEAO
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool NJMOCNBNDNL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct PNMNMMNJJFM
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate LJAGANKABPL GEPGKLJKMOE();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<GEPGKLJKMOE> HPIBHIKOLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<GEPGKLJKMOE> LNLJBKNLIKG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IEnumerable<GEPGKLJKMOE> IDOLODNOOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x64E6290", Offset = "0x64E5690", VA = "0x1864E6290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x64E6080", Offset = "0x64E5480", VA = "0x1864E6080")]
	public void BKCAAEBNAMB(GEPGKLJKMOE LMCBIJMLGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x64E6230", Offset = "0x64E5630", VA = "0x1864E6230")]
	public bool GAMANBAONBG(GEPGKLJKMOE LMCBIJMLGKM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum LJAGANKABPL
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum LFHAMFOIGKC
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	NavMeshGenerator,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	NavMeshIgnored,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	NavMeshBlocker
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OHJKGHLKIEI
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const int OJLIGMBNMFE = -1;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const long FFGNKAPDJFP = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private global::NGJFCLFEEIL<Guid, ObscuredLong, ObscuredInt, ObscuredBool> JKCDIPLPNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::JCDOELFAADB<ObscuredBool, ObscuredInt, ObscuredInt> KBOFJBEHABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MonoBehaviourPun CLPCALJPBGC;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Guid DHPBCFGHMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x64E5320", Offset = "0x64E4720", VA = "0x1864E5320")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public long DLDKCONCKOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x64E5630", Offset = "0x64E4A30", VA = "0x1864E5630")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int ACPIOAPHGIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x64E50B0", Offset = "0x64E44B0", VA = "0x1864E50B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AAHGFIBGNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x64E5450", Offset = "0x64E4850", VA = "0x1864E5450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GJPICMDEGHG
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x64E5720", Offset = "0x64E4B20", VA = "0x1864E5720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int NNFDNHNAPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x64E54F0", Offset = "0x64E48F0", VA = "0x1864E54F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int ABPAAGPJDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x64E5590", Offset = "0x64E4990", VA = "0x1864E5590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ONKCHOMFNMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x64E56E0", Offset = "0x64E4AE0", VA = "0x1864E56E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x64E5FD0", Offset = "0x64E53D0", VA = "0x1864E5FD0")]
	public OHJKGHLKIEI(MonoBehaviourPun PMFGMADNICA, string OKLPDGEECAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x64E5CA0", Offset = "0x64E50A0", VA = "0x1864E5CA0")]
	public OHJKGHLKIEI(MonoBehaviourPun PMFGMADNICA, string OKLPDGEECAC, Guid DACEEHHJIHP, long EENIGONCEJB, int KJPAAEKLGNK, bool GLDBCNEPFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x64E57C0", Offset = "0x64E4BC0", VA = "0x1864E57C0")]
	public void NJCHHAKNMBG(HIJGKEDACDC MNAPPIGFOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x64E5200", Offset = "0x64E4600", VA = "0x1864E5200")]
	public void FKHIJKAKOOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x64E5980", Offset = "0x64E4D80", VA = "0x1864E5980")]
	public void NPFGFFCDMGH(Guid BHNIMOLJBJO, long EENIGONCEJB, int KJPAAEKLGNK, bool GLDBCNEPFFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x64E5B60", Offset = "0x64E4F60", VA = "0x1864E5B60")]
	public void NPFGFFCDMGH(OHJKGHLKIEI FJLHJLAMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x64E5C30", Offset = "0x64E5030", VA = "0x1864E5C30")]
	public void OCBLCPLEOFL(IAEICJFMBGJ MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x64E5150", Offset = "0x64E4550", VA = "0x1864E5150")]
	public void COBEEKMMBJI(IAEICJFMBGJ MPEBBGJJODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x64E5390", Offset = "0x64E4790", VA = "0x1864E5390")]
	public static IAEICJFMBGJ HBLMMAFBIMH(Guid DACEEHHJIHP, long EENIGONCEJB, int GBBFMDINKHK, bool GLDBCNEPFFI)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x64E48D0", Offset = "0x64E3CD0", VA = "0x1864E48D0")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x64E4580", Offset = "0x64E3980", VA = "0x1864E4580")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
