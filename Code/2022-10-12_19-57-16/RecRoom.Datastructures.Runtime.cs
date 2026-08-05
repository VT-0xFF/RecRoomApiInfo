using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JKGMJPEPMFD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B1CE0", Offset = "0x6B0CE0", VA = "0x1806B1CE0")]
	public JKGMJPEPMFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, KPJDGDIGJNP, EMENMJPDFJB, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x66A140", Offset = "0x669140", VA = "0x18066A140", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x64B130", Offset = "0x64A130", VA = "0x18064B130", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72A040", Offset = "0x729040", VA = "0x18072A040", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash FPALDDOOOME);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xEE0200", Offset = "0xEDF200", VA = "0x180EE0200")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[HOFALDKJCKB]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[HOFALDKJCKB]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F630", Offset = "0x5D2E630", VA = "0x185D2F630")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F5F0", Offset = "0x5D2E5F0", VA = "0x185D2F5F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F670", Offset = "0x5D2E670", VA = "0x185D2F670")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F840", Offset = "0x5D2E840", VA = "0x185D2F840")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F7B0", Offset = "0x5D2E7B0", VA = "0x185D2F7B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x10C9020", Offset = "0x10C8020", VA = "0x1810C9020")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1285BE0", Offset = "0x1284BE0", VA = "0x181285BE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F5B0", Offset = "0x5D2E5B0", VA = "0x185D2F5B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F720", Offset = "0x5D2E720", VA = "0x185D2F720")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F1E0", Offset = "0x5D2E1E0", VA = "0x185D2F1E0")]
	public void CopyBounds(SavedExtents IIKMMJKCGDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F510", Offset = "0x5D2E510", VA = "0x185D2F510")]
	public void SetLocalSpaceBounds(Bounds GABNNFBJIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x11AD580", Offset = "0x11AC580", VA = "0x1811AD580")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F500", Offset = "0x5D2E500", VA = "0x185D2F500")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E9B0", Offset = "0x5D2D9B0", VA = "0x185D2E9B0")]
	private void BPLJFEABIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F2D0", Offset = "0x5D2E2D0", VA = "0x185D2F2D0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2EBA0", Offset = "0x5D2DBA0", VA = "0x185D2EBA0")]
	public static void CalculateLocalBoundsFor(GameObject HBGIADIFHEC, out Bounds GABNNFBJIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F210", Offset = "0x5D2E210", VA = "0x185D2F210")]
	private static void FJMNFMDFLEE(Bounds ENHIJCCJFBF, Color ODCENIJJKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2F530", Offset = "0x5D2E530", VA = "0x185D2F530")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x64A040", Offset = "0x649040", VA = "0x18064A040")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x66AF30", Offset = "0x669F30", VA = "0x18066AF30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x11AF890", Offset = "0x11AE890", VA = "0x1811AF890")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAF76F0", Offset = "0xAF66F0", VA = "0x180AF76F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "4")]
	public virtual void GBMLDPCEMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[JKGMJPEPMFD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C950", Offset = "0x2F7B950", VA = "0x182F7C950", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C080", Offset = "0x2F7B080", VA = "0x182F7C080", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2F7CE90", Offset = "0x2F7BE90", VA = "0x182F7CE90")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class AKJOFOCNHHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public AKJOFOCNHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x323DAB0", Offset = "0x323CAB0", VA = "0x18323DAB0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[JKGMJPEPMFD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2065600", Offset = "0x2064600", VA = "0x182065600", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2065630", Offset = "0x2064630", VA = "0x182065630", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2065550", Offset = "0x2064550", VA = "0x182065550", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey AGPLDPOAAIC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2065580", Offset = "0x2064580", VA = "0x182065580", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2065450", Offset = "0x2064450", VA = "0x182065450", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2064DD0", Offset = "0x2063DD0", VA = "0x182064DD0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x20644A0", Offset = "0x20634A0", VA = "0x1820644A0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2064380", Offset = "0x2063380", VA = "0x182064380", Slot = "14")]
	protected virtual string EILJHBCHBIN(TKeyVal NHOEILKDEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2064350", Offset = "0x2063350", VA = "0x182064350", Slot = "4")]
	public bool ContainsKey(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2065340", Offset = "0x2064340", VA = "0x182065340", Slot = "5")]
	public bool TryGetValue(TKey AGPLDPOAAIC, out TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2064410", Offset = "0x2063410", VA = "0x182064410", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2064410", Offset = "0x2063410", VA = "0x182064410", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2065370", Offset = "0x2064370", VA = "0x182065370")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class FKGGGLOGLBF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KHJGNOLMKDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public KHJGNOLMKDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2901990", Offset = "0x2900990", VA = "0x182901990")]
		internal bool <GetSamples>b__0(global::PCDEGCOHKDJ<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float APONKIIMCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float PPBKFFHDMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::PCDEGCOHKDJ<float, T>> OONEMLCDEPG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int JFDBPPNEHFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x25BCF70", Offset = "0x25BBF70", VA = "0x1825BCF70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x25BD580", Offset = "0x25BC580", VA = "0x1825BD580")]
	public FKGGGLOGLBF(float PLOJHEJNDDO, float ELOGMMNOJKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x25BD420", Offset = "0x25BC420", VA = "0x1825BD420")]
	public bool PIGHMNFFOCG(float EGGBPIADIJM, T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x25BCF10", Offset = "0x25BBF10", VA = "0x1825BCF10")]
	public int AEMBDLEHKPG(float EGGBPIADIJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x25BCFF0", Offset = "0x25BBFF0", VA = "0x1825BCFF0")]
	public IEnumerable<T> HPAJBAGDIDB(float EGGBPIADIJM, [Optional] float? ALKMIOAKPGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x25BD330", Offset = "0x25BC330", VA = "0x1825BD330")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x25BD360", Offset = "0x25BC360", VA = "0x1825BD360")]
	private void PCCODNKDGNF(float EGGBPIADIJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class JKNBBIBGCKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct KLGMDFIEAFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T FHONEBOCBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float ENFOOFFCBIJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float NHEMOGDEDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> GCMIGLPOMCK;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int PEMIJNILLMA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private KLGMDFIEAFM[] KPAFOBEJBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int MGKKIHJFNBG;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float BJABMKAGLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xE9F390", Offset = "0xE9E390", VA = "0x180E9F390")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE9F3A0", Offset = "0xE9E3A0", VA = "0x180E9F3A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x311B930", Offset = "0x311A930", VA = "0x18311B930")]
	public JKNBBIBGCKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x311B960", Offset = "0x311A960", VA = "0x18311B960")]
	public JKNBBIBGCKA(int FBPAKFCOLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x311A480", Offset = "0x3119480", VA = "0x18311A480")]
	public void CEMPCIEDPMO(float EGGBPIADIJM, T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x311B070", Offset = "0x311A070", VA = "0x18311B070")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x311AA70", Offset = "0x3119A70", VA = "0x18311AA70")]
	public bool FKIGDPLAMLK(float LOJOCJJCFJJ, float INNKEDNIBHO, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x311B610", Offset = "0x311A610", VA = "0x18311B610")]
	public bool PPNEFHEKNBJ(float LOJOCJJCFJJ, float INNKEDNIBHO, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x311A700", Offset = "0x3119700", VA = "0x18311A700")]
	public void CPCPCLMJKAO(float LOJOCJJCFJJ, float INNKEDNIBHO, List<T> NCCOCLJLPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x311B040", Offset = "0x311A040", VA = "0x18311B040")]
	private int OCNMNDIFALO(int ELPOAPOJMKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x311B000", Offset = "0x311A000", VA = "0x18311B000")]
	private void MIACIOFBAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JMMIFEIPPIK();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BPMGPKIJKNO(T FEBCAKEBBCL, T EEACLMBPLFE, float HLNBIKMPIPM);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T KEKPNJHGAAA(T CCIMHDCKHOF, float HLNBIKMPIPM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T NCJEMFEINGH(T FEBCAKEBBCL, T EEACLMBPLFE);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T BLGHHHHNLDA(T FEBCAKEBBCL, T EEACLMBPLFE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KJGGABKNDGO : global::JKNBBIBGCKA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x10E8310", Offset = "0x10E7310", VA = "0x1810E8310", Slot = "4")]
	protected override Vector3 JMMIFEIPPIK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1A45980", Offset = "0x1A44980", VA = "0x181A45980", Slot = "5")]
	protected override Vector3 BPMGPKIJKNO(Vector3 FEBCAKEBBCL, Vector3 EEACLMBPLFE, float HLNBIKMPIPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CF90", Offset = "0x5D2BF90", VA = "0x185D2CF90", Slot = "6")]
	protected override Vector3 KEKPNJHGAAA(Vector3 CCIMHDCKHOF, float HLNBIKMPIPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CFF0", Offset = "0x5D2BFF0", VA = "0x185D2CFF0", Slot = "7")]
	protected override Vector3 NCJEMFEINGH(Vector3 FEBCAKEBBCL, Vector3 EEACLMBPLFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CF20", Offset = "0x5D2BF20", VA = "0x185D2CF20", Slot = "8")]
	protected override Vector3 BLGHHHHNLDA(Vector3 FEBCAKEBBCL, Vector3 EEACLMBPLFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D070", Offset = "0x5D2C070", VA = "0x185D2D070")]
	public KJGGABKNDGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JGIBPFEHCOA : global::JKNBBIBGCKA<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CCD0", Offset = "0x5D2BCD0", VA = "0x185D2CCD0")]
	public JGIBPFEHCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CD40", Offset = "0x5D2BD40", VA = "0x185D2CD40")]
	public JGIBPFEHCOA(int FBPAKFCOLHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xFD6970", Offset = "0xFD5970", VA = "0x180FD6970", Slot = "4")]
	protected override float JMMIFEIPPIK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x36A0F60", Offset = "0x369FF60", VA = "0x1836A0F60", Slot = "5")]
	protected override float BPMGPKIJKNO(float FEBCAKEBBCL, float EEACLMBPLFE, float HLNBIKMPIPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4F23DB0", Offset = "0x4F22DB0", VA = "0x184F23DB0", Slot = "6")]
	protected override float KEKPNJHGAAA(float CCIMHDCKHOF, float HLNBIKMPIPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B8F6C0", Offset = "0x2B8E6C0", VA = "0x182B8F6C0", Slot = "7")]
	protected override float NCJEMFEINGH(float FEBCAKEBBCL, float EEACLMBPLFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CCC0", Offset = "0x5D2BCC0", VA = "0x185D2CCC0", Slot = "8")]
	protected override float BLGHHHHNLDA(float FEBCAKEBBCL, float EEACLMBPLFE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LNCBPFHPONE
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D0B0", Offset = "0x1F2C0B0", VA = "0x181F2D0B0")]
	public static global::EBBAFIMJLGL<T1> MFNJFAEBAIM<T1>(T1 ACEMJELMOGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x27F0650", Offset = "0x27EF650", VA = "0x1827F0650")]
	public static global::PCDEGCOHKDJ<T1, T2> MFNJFAEBAIM<T1, T2>(T1 ACEMJELMOGM, T2 GAPICALCGJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x27F06C0", Offset = "0x27EF6C0", VA = "0x1827F06C0")]
	public static global::BCFAGHJINLH<T1, T2, T3> MFNJFAEBAIM<T1, T2, T3>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2653810", Offset = "0x2652810", VA = "0x182653810")]
	public static global::AADFFFHOFCL<T1, T2, T3, T4> MFNJFAEBAIM<T1, T2, T3, T4>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x27F0990", Offset = "0x27EF990", VA = "0x1827F0990")]
	public static global::DNJCHJICCOI<T1, T2, T3, T4, T5> MFNJFAEBAIM<T1, T2, T3, T4, T5>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x27F08E0", Offset = "0x27EF8E0", VA = "0x1827F08E0")]
	public static global::AIGHOCGJNCK<T1, T2, T3, T4, T5, T6> MFNJFAEBAIM<T1, T2, T3, T4, T5, T6>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x27F0820", Offset = "0x27EF820", VA = "0x1827F0820")]
	public static global::FFHGBANFKPI<T1, T2, T3, T4, T5, T6, T7> MFNJFAEBAIM<T1, T2, T3, T4, T5, T6, T7>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB, T7 CAECJEPJMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x27F0750", Offset = "0x27EF750", VA = "0x1827F0750")]
	public static global::OACANGNDKPP<T1, T2, T3, T4, T5, T6, T7, T8> MFNJFAEBAIM<T1, T2, T3, T4, T5, T6, T7, T8>(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB, T7 CAECJEPJMMI, T8 ONMDJGHGNAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1C56100", Offset = "0x1C55100", VA = "0x181C56100")]
	[IteratorStateMachine(typeof(NGFIEFACPCC))]
	public static IEnumerable<global::PCDEGCOHKDJ<T1, T2>> NGILIIACPLC<T1, T2>(IEnumerable<T1> DOGOAAONBOH, IEnumerable<T2> ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1C562E0", Offset = "0x1C552E0", VA = "0x181C562E0")]
	[IteratorStateMachine(typeof(DAGEALJDAMA))]
	public static IEnumerable<global::BCFAGHJINLH<T1, T2, T3>> NGILIIACPLC<T1, T2, T3>(IEnumerable<T1> DOGOAAONBOH, IEnumerable<T2> ENHIJCCJFBF, IEnumerable<T3> ODCENIJJKIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x83AAE0", Offset = "0x839AE0", VA = "0x18083AAE0")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x83AAD0", Offset = "0x839AD0", VA = "0x18083AAD0")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x83AAB0", Offset = "0x839AB0", VA = "0x18083AAB0")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ, int GDLJDFIMKLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DA90", Offset = "0x5D2CA90", VA = "0x185D2DA90")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ, int GDLJDFIMKLA, int IHICGHBAKBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DAE0", Offset = "0x5D2CAE0", VA = "0x185D2DAE0")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ, int GDLJDFIMKLA, int IHICGHBAKBD, int OFDAPPFJFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DAB0", Offset = "0x5D2CAB0", VA = "0x185D2DAB0")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ, int GDLJDFIMKLA, int IHICGHBAKBD, int OFDAPPFJFHF, int OCOOKLDCJCB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DB00", Offset = "0x5D2CB00", VA = "0x185D2DB00")]
	internal static int KABJPFBKPEF(int JNIGJMDFMBK, int FCMCCDNBGOA, int KBFABFCAFHJ, int GDLJDFIMKLA, int IHICGHBAKBD, int OFDAPPFJFHF, int OCOOKLDCJCB, int EMALKHJKEEB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EBBAFIMJLGL<T1> : IComparable<global::EBBAFIMJLGL<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x1BB9BB0", Offset = "0x1BB8BB0", VA = "0x181BB9BB0")]
	public EBBAFIMJLGL(T1 ACEMJELMOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2991C60", Offset = "0x2990C60", VA = "0x182991C60", Slot = "4")]
	public int CompareTo(global::EBBAFIMJLGL<T1> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x2991CD0", Offset = "0x2990CD0", VA = "0x182991CD0", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9437A0", Offset = "0x9427A0", VA = "0x1809437A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x2991D70", Offset = "0x2990D70", VA = "0x182991D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PCDEGCOHKDJ<T1, T2> : IComparable<global::PCDEGCOHKDJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3210320", Offset = "0x320F320", VA = "0x183210320")]
	public PCDEGCOHKDJ(T1 ACEMJELMOGM, T2 GAPICALCGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x320E510", Offset = "0x320D510", VA = "0x18320E510", Slot = "4")]
	public int CompareTo(global::PCDEGCOHKDJ<T1, T2> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x320EBD0", Offset = "0x320DBD0", VA = "0x18320EBD0", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x320F7D0", Offset = "0x320E7D0", VA = "0x18320F7D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x320FB70", Offset = "0x320EB70", VA = "0x18320FB70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BCFAGHJINLH<T1, T2, T3> : IComparable<global::BCFAGHJINLH<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4267D00", Offset = "0x4266D00", VA = "0x184267D00")]
	public BCFAGHJINLH(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x42675F0", Offset = "0x42665F0", VA = "0x1842675F0", Slot = "4")]
	public int CompareTo(global::BCFAGHJINLH<T1, T2, T3> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x42676F0", Offset = "0x42666F0", VA = "0x1842676F0", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4267950", Offset = "0x4266950", VA = "0x184267950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4267A40", Offset = "0x4266A40", VA = "0x184267A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AADFFFHOFCL<T1, T2, T3, T4> : IComparable<global::AADFFFHOFCL<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 PNDNLJBNMHI;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x268CED0", Offset = "0x268BED0", VA = "0x18268CED0")]
	public AADFFFHOFCL(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x26C82F0", Offset = "0x26C72F0", VA = "0x1826C82F0", Slot = "4")]
	public int CompareTo(global::AADFFFHOFCL<T1, T2, T3, T4> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x26C8430", Offset = "0x26C7430", VA = "0x1826C8430", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x26C8550", Offset = "0x26C7550", VA = "0x1826C8550", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x26C8610", Offset = "0x26C7610", VA = "0x1826C8610", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class DNJCHJICCOI<T1, T2, T3, T4, T5> : IComparable<global::DNJCHJICCOI<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 PNDNLJBNMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 NNCGHOCNCAM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x25AF5B0", Offset = "0x25AE5B0", VA = "0x1825AF5B0")]
	public DNJCHJICCOI(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BA00", Offset = "0x2E4AA00", VA = "0x182E4BA00", Slot = "4")]
	public int CompareTo(global::DNJCHJICCOI<T1, T2, T3, T4, T5> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BB80", Offset = "0x2E4AB80", VA = "0x182E4BB80", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BCC0", Offset = "0x2E4ACC0", VA = "0x182E4BCC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x2E4BDC0", Offset = "0x2E4ADC0", VA = "0x182E4BDC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AIGHOCGJNCK<T1, T2, T3, T4, T5, T6> : IComparable<global::AIGHOCGJNCK<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 PNDNLJBNMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 NNCGHOCNCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 KMOGHAAJHLP;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x323CE50", Offset = "0x323BE50", VA = "0x18323CE50")]
	public AIGHOCGJNCK(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x323C890", Offset = "0x323B890", VA = "0x18323C890", Slot = "4")]
	public int CompareTo(global::AIGHOCGJNCK<T1, T2, T3, T4, T5, T6> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x323CA50", Offset = "0x323BA50", VA = "0x18323CA50", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x323CBC0", Offset = "0x323BBC0", VA = "0x18323CBC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x323CCE0", Offset = "0x323BCE0", VA = "0x18323CCE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FFHGBANFKPI<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::FFHGBANFKPI<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 PNDNLJBNMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 NNCGHOCNCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 KMOGHAAJHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 CJPDFDFPDIC;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x25B4480", Offset = "0x25B3480", VA = "0x1825B4480")]
	public FFHGBANFKPI(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB, T7 CAECJEPJMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x25B3E00", Offset = "0x25B2E00", VA = "0x1825B3E00", Slot = "4")]
	public int CompareTo(global::FFHGBANFKPI<T1, T2, T3, T4, T5, T6, T7> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x25B4000", Offset = "0x25B3000", VA = "0x1825B4000", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x25B41A0", Offset = "0x25B31A0", VA = "0x1825B41A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x25B42F0", Offset = "0x25B32F0", VA = "0x1825B42F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OACANGNDKPP<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::OACANGNDKPP<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 JBGJAIKHDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 FAOKNAJDLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 PGFAFMFIKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 PNDNLJBNMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 NNCGHOCNCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 KMOGHAAJHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 CJPDFDFPDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 NDPMCDDPDLL;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3381330", Offset = "0x3380330", VA = "0x183381330")]
	public OACANGNDKPP(T1 ACEMJELMOGM, T2 GAPICALCGJE, T3 KOPEHBNOOLB, T4 MCEEJKFKEEF, T5 FBJKJNIJDGB, T6 FINDENMHPDB, T7 CAECJEPJMMI, T8 ONMDJGHGNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3380C00", Offset = "0x337FC00", VA = "0x183380C00", Slot = "4")]
	public int CompareTo(global::OACANGNDKPP<T1, T2, T3, T4, T5, T6, T7, T8> IIKMMJKCGDO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3380E50", Offset = "0x337FE50", VA = "0x183380E50", Slot = "0")]
	public override bool Equals(object IIKMMJKCGDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3381010", Offset = "0x3380010", VA = "0x183381010", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3381180", Offset = "0x3380180", VA = "0x183381180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1A8B450", Offset = "0x1A8A450", VA = "0x181A8B450")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3BB8510", Offset = "0x3BB7510", VA = "0x183BB8510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float IJHFAAMLALE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1114EF0", Offset = "0x1113EF0", VA = "0x181114EF0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8420", Offset = "0x3BB7420", VA = "0x183BB8420")]
	public T KKONMFJNIDB(float HLNBIKMPIPM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8070", Offset = "0x3BB7070", VA = "0x183BB8070")]
	public T IGGNKOFAMGP(float HLNBIKMPIPM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BPMGPKIJKNO(T FEBCAKEBBCL, T EEACLMBPLFE, float HLNBIKMPIPM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x36A0F60", Offset = "0x369FF60", VA = "0x1836A0F60", Slot = "4")]
	protected override float BPMGPKIJKNO(float FEBCAKEBBCL, float EEACLMBPLFE, float HLNBIKMPIPM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C1F0", Offset = "0x5D2B1F0", VA = "0x185D2C1F0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x1A45980", Offset = "0x1A44980", VA = "0x181A45980", Slot = "4")]
	protected override Vector3 BPMGPKIJKNO(Vector3 FEBCAKEBBCL, Vector3 EEACLMBPLFE, float HLNBIKMPIPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D307D0", Offset = "0x5D2F7D0", VA = "0x185D307D0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B450", Offset = "0x5D2A450", VA = "0x185D2B450", Slot = "4")]
	protected override Color BPMGPKIJKNO(Color FEBCAKEBBCL, Color EEACLMBPLFE, float HLNBIKMPIPM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B4A0", Offset = "0x5D2A4A0", VA = "0x185D2B4A0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HBABPOCCMCF : global::LMKLFAIBJID<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C630", Offset = "0x5D2B630", VA = "0x185D2C630")]
	public HBABPOCCMCF(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C5D0", Offset = "0x5D2B5D0", VA = "0x185D2C5D0")]
	public HBABPOCCMCF(IMHFCBKOGIC[] EDKOFDEAJAI, bool PAIPMGNEBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C560", Offset = "0x5D2B560", VA = "0x185D2C560", Slot = "6")]
	protected override uint EDMBNPDCFGI(uint FPALDDOOOME, string CCIMHDCKHOF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class GGKDCIMGNHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public GGKDCIMGNHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct DJNBKKPBGNP
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EEGIGLBEFPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<FDAEEOMAIHB> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public EEGIGLBEFPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C160", Offset = "0x5D2B160", VA = "0x185D2C160")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<FDAEEOMAIHB>> GPPHEFKMMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FJPPNJPIPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int HFAEEOMPAAF;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xCD9A70", Offset = "0xCD8A70", VA = "0x180CD9A70")]
	private DJNBKKPBGNP(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<FDAEEOMAIHB>> FPONBIFGBCD, int IBFAGBMACIE, int EKAJLPLOKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B710", Offset = "0x5D2A710", VA = "0x185D2B710")]
	public static DJNBKKPBGNP AKMEFLONJDG()
	{
		return default(DJNBKKPBGNP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B790", Offset = "0x5D2A790", VA = "0x185D2B790")]
	public (int, int, Task) CODNIHGIFBG(int OBCKDJNBOCN, [Optional] CancellationToken OHJGLBPIBBN)
	{
		return default((int, int, Task));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BB80", Offset = "0x5D2AB80", VA = "0x185D2BB80")]
	public void OFPJHFHFEEK(int OBCKDJNBOCN, int EKAJLPLOKDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[DefaultMember("Item")]
public class BMHOONCNFAE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> LCBCGHKBGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> LJLDGEJCNBJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x2026530", Offset = "0x2025530", VA = "0x182026530", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> BOJKPFIKJDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x26ED890", Offset = "0x26EC890", VA = "0x1826ED890", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> CFGJONBEJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2056B80", Offset = "0x2055B80", VA = "0x182056B80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x27834C0", Offset = "0x27824C0", VA = "0x1827834C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x23685F0", Offset = "0x23675F0", VA = "0x1823685F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x27832B0", Offset = "0x27822B0", VA = "0x1827832B0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2782CC0", Offset = "0x2781CC0", VA = "0x182782CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x2782BA0", Offset = "0x2781BA0", VA = "0x182782BA0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x2783340", Offset = "0x2782340", VA = "0x182783340", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x27827A0", Offset = "0x27817A0", VA = "0x1827827A0", Slot = "9")]
	public void Add(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x2782800", Offset = "0x2781800", VA = "0x182782800", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x2782C00", Offset = "0x2781C00", VA = "0x182782C00", Slot = "8")]
	public bool ContainsKey(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x24044A0", Offset = "0x24034A0", VA = "0x1824044A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x27832E0", Offset = "0x27822E0", VA = "0x1827832E0", Slot = "10")]
	public bool Remove(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x27832E0", Offset = "0x27822E0", VA = "0x1827832E0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x2056C10", Offset = "0x2055C10", VA = "0x182056C10", Slot = "11")]
	public bool TryGetValue(TKey AGPLDPOAAIC, out TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x2783120", Offset = "0x2782120", VA = "0x182783120", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x2782C60", Offset = "0x2781C60", VA = "0x182782C60", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x27829A0", Offset = "0x27819A0", VA = "0x1827829A0")]
	public void CEMPCIEDPMO(TVal OGAPHEEOKGM, TKey AGPLDPOAAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x2782A50", Offset = "0x2781A50", VA = "0x182782A50")]
	public void CEMPCIEDPMO(KeyValuePair<TVal, TKey> EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x2782D70", Offset = "0x2781D70", VA = "0x182782D70")]
	public bool FPLHHNNFOGE(TVal AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x2782940", Offset = "0x2781940", VA = "0x182782940")]
	public bool CBBIGPLMGHA(KeyValuePair<TVal, TKey> EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x2782740", Offset = "0x2781740", VA = "0x182782740")]
	public bool ADDEDGCCJIP(TVal AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x2782740", Offset = "0x2781740", VA = "0x182782740")]
	public bool ADDEDGCCJIP(KeyValuePair<TVal, TKey> EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x2782D40", Offset = "0x2781D40", VA = "0x182782D40")]
	public bool EPBHELLGDLM(TVal AGPLDPOAAIC, out TKey CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x2782A90", Offset = "0x2781A90", VA = "0x182782A90")]
	public IEnumerator<KeyValuePair<TVal, TKey>> CIAPMPDJJAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x27828C0", Offset = "0x27818C0", VA = "0x1827828C0")]
	private void BNKODGOIFDM(TKey AGPLDPOAAIC, TVal OGAPHEEOKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x2783230", Offset = "0x2782230", VA = "0x182783230")]
	private void LNHFLDDOFKH(TKey AGPLDPOAAIC, TVal OGAPHEEOKGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x2782F20", Offset = "0x2781F20", VA = "0x182782F20")]
	private bool GMMBBPAKCJJ(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x2782E60", Offset = "0x2781E60", VA = "0x182782E60")]
	private bool GMMBBPAKCJJ(TVal OGAPHEEOKGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x27833E0", Offset = "0x27823E0", VA = "0x1827833E0")]
	public BMHOONCNFAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class LLLEADJIAFA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::LLLEADJIAFA<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x2E33DA0", Offset = "0x2E32DA0", VA = "0x182E33DA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2E36330", Offset = "0x2E35330", VA = "0x182E36330")]
		public Enumerator(global::LLLEADJIAFA<T> NCCOCLJLPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2E31F10", Offset = "0x2E30F10", VA = "0x182E31F10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2E327C0", Offset = "0x2E317C0", VA = "0x182E327C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2E2EA10", Offset = "0x2E2DA10", VA = "0x182E2EA10")]
		private void HHMILLHIJOB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] DOACBDBBJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int OFHLFABGMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int KJCIMGFJDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int LDFDMKAILBI;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1F40", Offset = "0x2AB0F40", VA = "0x182AB1F40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AB2D70", Offset = "0x2AB1D70", VA = "0x182AB2D70")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AB1E30", Offset = "0x2AB0E30", VA = "0x182AB1E30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3320", Offset = "0x2AB2320", VA = "0x182AB3320")]
	public LLLEADJIAFA(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x2AB16C0", Offset = "0x2AB06C0", VA = "0x182AB16C0")]
	public void CEMPCIEDPMO(T HLNBIKMPIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x2AB2040", Offset = "0x2AB1040", VA = "0x182AB2040")]
	public void JLOEGDMEDIN(IEnumerable<T> NMJNDGPGMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3180", Offset = "0x2AB2180", VA = "0x182AB3180")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1EB0", Offset = "0x2AB0EB0", VA = "0x182AB1EB0")]
	public void DMJEDPELCAN(int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1FB0", Offset = "0x2AB0FB0", VA = "0x182AB1FB0")]
	public void JGGJCBHGCIF(int LGKBEOCJMLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1780", Offset = "0x2AB0780", VA = "0x182AB1780")]
	public void DFDKBNEOJKD(T[] KPAFOBEJBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x2AB13E0", Offset = "0x2AB03E0", VA = "0x182AB13E0")]
	public Enumerator CDEDLLPMOKO()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AB31A0", Offset = "0x2AB21A0", VA = "0x182AB31A0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x2AB31A0", Offset = "0x2AB21A0", VA = "0x182AB31A0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x2AB3090", Offset = "0x2AB2090", VA = "0x182AB3090")]
	private int OBCBDCEGGDM(int MMABPPDCBIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x2AB1F80", Offset = "0x2AB0F80", VA = "0x182AB1F80")]
	private int FLKCHGOOOLE(int MMABPPDCBIB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DefaultMember("Item")]
public class KLOBBAKJNJJ<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> KLINPOPBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> AOAOCMABBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> PIJDNOPJENO;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> CFCOMKLOGLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x64B130", Offset = "0x64A130", VA = "0x18064B130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x755B40", Offset = "0x754B40", VA = "0x180755B40", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x704170", Offset = "0x703170", VA = "0x180704170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x30C4ED0", Offset = "0x30C3ED0", VA = "0x1830C4ED0", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x30C4F70", Offset = "0x30C3F70", VA = "0x1830C4F70", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x30C4E70", Offset = "0x30C3E70", VA = "0x1830C4E70", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x2AAA180", Offset = "0x2AA9180", VA = "0x182AAA180")]
	public KLOBBAKJNJJ(Func<Internal, External> KLINPOPBADJ, Func<External, Internal> AOAOCMABBCP, bool ELNPFHKAOAA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x30C4B90", Offset = "0x30C3B90", VA = "0x1830C4B90", Slot = "6")]
	public int IndexOf(External EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x30C4810", Offset = "0x30C3810", VA = "0x1830C4810", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x30C4870", Offset = "0x30C3870", VA = "0x1830C4870", Slot = "13")]
	public bool Contains(External EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x30C4900", Offset = "0x30C3900", VA = "0x1830C4900", Slot = "14")]
	public void CopyTo(External[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x30C4720", Offset = "0x30C3720", VA = "0x1830C4720", Slot = "11")]
	public void Add(External EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x30C4C80", Offset = "0x30C3C80", VA = "0x1830C4C80", Slot = "7")]
	public void Insert(int MMABPPDCBIB, External EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x30C4DE0", Offset = "0x30C3DE0", VA = "0x1830C4DE0", Slot = "15")]
	public bool Remove(External EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x30C4D20", Offset = "0x30C3D20", VA = "0x1830C4D20", Slot = "8")]
	public void RemoveAt(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x30C4B20", Offset = "0x30C3B20", VA = "0x1830C4B20", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x236FF70", Offset = "0x236EF70", VA = "0x18236FF70", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class LGBMOOIAHED<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> KLINPOPBADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> PIJDNOPJENO;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> CFCOMKLOGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x66A140", Offset = "0x669140", VA = "0x18066A140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2AA59E0", Offset = "0x2AA49E0", VA = "0x182AA59E0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x2AA5980", Offset = "0x2AA4980", VA = "0x182AA5980", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1BB9BB0", Offset = "0x1BB8BB0", VA = "0x181BB9BB0")]
	public LGBMOOIAHED(Func<Internal, External> KLINPOPBADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x2AA5930", Offset = "0x2AA4930", VA = "0x182AA5930")]
	public LGBMOOIAHED(IReadOnlyList<Internal> PIJDNOPJENO, Func<Internal, External> KLINPOPBADJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x2AA56A0", Offset = "0x2AA46A0", VA = "0x182AA56A0")]
	public void DFDKBNEOJKD(External[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x2AA58C0", Offset = "0x2AA48C0", VA = "0x182AA58C0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x25BB960", Offset = "0x25BA960", VA = "0x1825BB960", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class PODCINKBEFJ<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> PIJDNOPJENO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> CFCOMKLOGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x66A130", Offset = "0x669130", VA = "0x18066A130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2515F20", Offset = "0x2514F20", VA = "0x182515F20", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2515EC0", Offset = "0x2514EC0", VA = "0x182515EC0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x1BB9BB0", Offset = "0x1BB8BB0", VA = "0x181BB9BB0")]
	public PODCINKBEFJ(IReadOnlyList<Internal> PIJDNOPJENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x2515B80", Offset = "0x2514B80", VA = "0x182515B80")]
	public bool CBBIGPLMGHA(External EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x2515C20", Offset = "0x2514C20", VA = "0x182515C20")]
	public void DFDKBNEOJKD(External[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2515E50", Offset = "0x2514E50", VA = "0x182515E50", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x236FF70", Offset = "0x236EF70", VA = "0x18236FF70", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class HHKDEEAFFCF
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void IBCOCCDCDEF(object[] GOLEKIJBOAN);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	protected HHKDEEAFFCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class NMOLAGMGIFL<T> : HHKDEEAFFCF
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	protected struct OPCEFNCHMKH
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public enum LCPFCMJGDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LCPFCMJGDLJ BCFKLEGAMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T NCHNGIGODJK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int NLIFEGOADHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool ECCFKJNMKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool EGMOJIIMFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> MGDLLHEPMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<OPCEFNCHMKH> PIPLNLNHNMJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IELELMEGGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2E27DF0", Offset = "0x2E26DF0", VA = "0x182E27DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x2E28000", Offset = "0x2E27000", VA = "0x182E28000")]
	protected NMOLAGMGIFL(bool EGMOJIIMFHP, bool ECCFKJNMKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x2E27A60", Offset = "0x2E26A60", VA = "0x182E27A60")]
	protected bool BFOIIFOEBFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x2E27E30", Offset = "0x2E26E30", VA = "0x182E27E30")]
	protected void JCOPDCPKDPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2E27AE0", Offset = "0x2E26AE0", VA = "0x182E27AE0")]
	protected void CAAOODCFKJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3C4FC90", Offset = "0x3C4EC90", VA = "0x183C4FC90")]
	private static void GCJPPMAFMEN<U>(ref List<U> PIJDNOPJENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2E27C90", Offset = "0x2E26C90", VA = "0x182E27C90", Slot = "5")]
	public void CEMPCIEDPMO(T NCHNGIGODJK, bool NGLFMPIMFDE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x2E27920", Offset = "0x2E26920", VA = "0x182E27920", Slot = "6")]
	public void ADDEDGCCJIP(T NCHNGIGODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x2E27EF0", Offset = "0x2E26EF0", VA = "0x182E27EF0")]
	public void OJEEPLKEKIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HGGLDMFOFMG
{
	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public sealed class CMOPDACJGKG : global::NMOLAGMGIFL<Action>, HGGLDMFOFMG
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B3F0", Offset = "0x5D2A3F0", VA = "0x185D2B3F0")]
	public CMOPDACJGKG(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B180", Offset = "0x5D2A180", VA = "0x185D2B180")]
	public void JAKEEOPOMIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B0B0", Offset = "0x5D2A0B0", VA = "0x185D2B0B0", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B120", Offset = "0x5D2A120", VA = "0x185D2B120")]
	public static CMOPDACJGKG IDPFAKACPID(CMOPDACJGKG EBJJKPBLHEG, Action NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B390", Offset = "0x5D2A390", VA = "0x185D2B390")]
	public static CMOPDACJGKG MMBIJLAKMHD(CMOPDACJGKG EBJJKPBLHEG, Action NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface OEOJBFINKLO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public sealed class DPCNIAMGAEP<T> : global::NMOLAGMGIFL<Action<T>>, global::OEOJBFINKLO<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x1BAEF20", Offset = "0x1BADF20", VA = "0x181BAEF20")]
	public DPCNIAMGAEP(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2E500B0", Offset = "0x2E4F0B0", VA = "0x182E500B0")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2E4E4D0", Offset = "0x2E4D4D0", VA = "0x182E4E4D0", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2E4F290", Offset = "0x2E4E290", VA = "0x182E4F290")]
	public static global::DPCNIAMGAEP<T> IDPFAKACPID(global::DPCNIAMGAEP<T> EBJJKPBLHEG, Action<T> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2E50340", Offset = "0x2E4F340", VA = "0x182E50340")]
	public static global::DPCNIAMGAEP<T> MMBIJLAKMHD(global::DPCNIAMGAEP<T> EBJJKPBLHEG, Action<T> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface LLLPJNEJFGG<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T, U> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T, U> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class DCBNKGAHPLA<T, U> : global::NMOLAGMGIFL<Action<T, U>>, global::LLLPJNEJFGG<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1BAEF20", Offset = "0x1BADF20", VA = "0x181BAEF20")]
	public DCBNKGAHPLA(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x381E9F0", Offset = "0x381D9F0", VA = "0x18381E9F0")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM, U DIPNKMENNJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x381C590", Offset = "0x381B590", VA = "0x18381C590", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x381E290", Offset = "0x381D290", VA = "0x18381E290")]
	public static global::DCBNKGAHPLA<T, U> IDPFAKACPID(global::DCBNKGAHPLA<T, U> EBJJKPBLHEG, Action<T, U> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3820830", Offset = "0x381F830", VA = "0x183820830")]
	public static global::DCBNKGAHPLA<T, U> MMBIJLAKMHD(global::DCBNKGAHPLA<T, U> EBJJKPBLHEG, Action<T, U> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface KLKFMGDGCHB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T, U, V> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T, U, V> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public sealed class OKKMIGNKDFJ<T, U, V> : global::NMOLAGMGIFL<Action<T, U, V>>, global::KLKFMGDGCHB<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1BAEF20", Offset = "0x1BADF20", VA = "0x181BAEF20")]
	public OKKMIGNKDFJ(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x2D8B890", Offset = "0x2D8A890", VA = "0x182D8B890")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM, U DIPNKMENNJO, V DCNCBDGEKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2D896A0", Offset = "0x2D886A0", VA = "0x182D896A0", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x2D8A790", Offset = "0x2D89790", VA = "0x182D8A790")]
	public static global::OKKMIGNKDFJ<T, U, V> IDPFAKACPID(global::OKKMIGNKDFJ<T, U, V> EBJJKPBLHEG, Action<T, U, V> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x2D8C640", Offset = "0x2D8B640", VA = "0x182D8C640")]
	public static global::OKKMIGNKDFJ<T, U, V> MMBIJLAKMHD(global::OKKMIGNKDFJ<T, U, V> EBJJKPBLHEG, Action<T, U, V> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KHLJFCEFDGG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T, U, V, W> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T, U, V, W> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public sealed class MOBMMDELNAG<T, U, V, W> : global::NMOLAGMGIFL<Action<T, U, V, W>>, global::KHLJFCEFDGG<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x1BAEF20", Offset = "0x1BADF20", VA = "0x181BAEF20")]
	public MOBMMDELNAG(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x2A1EE90", Offset = "0x2A1DE90", VA = "0x182A1EE90")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM, U DIPNKMENNJO, V DCNCBDGEKMD, W NOMPHPBFLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2A1D420", Offset = "0x2A1C420", VA = "0x182A1D420", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2A1DEA0", Offset = "0x2A1CEA0", VA = "0x182A1DEA0")]
	public static global::MOBMMDELNAG<T, U, V, W> IDPFAKACPID(global::MOBMMDELNAG<T, U, V, W> EBJJKPBLHEG, Action<T, U, V, W> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2A1F440", Offset = "0x2A1E440", VA = "0x182A1F440")]
	public static global::MOBMMDELNAG<T, U, V, W> MMBIJLAKMHD(global::MOBMMDELNAG<T, U, V, W> EBJJKPBLHEG, Action<T, U, V, W> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CJMDMOCANJH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T, U, V, W, X> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T, U, V, W, X> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class FDECHEGKDNF<T, U, V, W, X> : global::NMOLAGMGIFL<Action<T, U, V, W, X>>, global::CJMDMOCANJH<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x1BAEF20", Offset = "0x1BADF20", VA = "0x181BAEF20")]
	public FDECHEGKDNF(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x25AEDA0", Offset = "0x25ADDA0", VA = "0x1825AEDA0")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM, U DIPNKMENNJO, V DCNCBDGEKMD, W NOMPHPBFLNE, X ODLLFOGPPIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x25AE6F0", Offset = "0x25AD6F0", VA = "0x1825AE6F0", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x25AED00", Offset = "0x25ADD00", VA = "0x1825AED00")]
	public static global::FDECHEGKDNF<T, U, V, W, X> IDPFAKACPID(global::FDECHEGKDNF<T, U, V, W, X> EBJJKPBLHEG, Action<T, U, V, W, X> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x25AF360", Offset = "0x25AE360", VA = "0x1825AF360")]
	public static global::FDECHEGKDNF<T, U, V, W, X> MMBIJLAKMHD(global::FDECHEGKDNF<T, U, V, W, X> EBJJKPBLHEG, Action<T, U, V, W, X> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GBNPNCIMPGD<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEMPCIEDPMO(Action<T, U, V, W, X, Y> NCHNGIGODJK, bool NGLFMPIMFDE = false);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ADDEDGCCJIP(Action<T, U, V, W, X, Y> NCHNGIGODJK);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class PPDMDPBDHCF<T, U, V, W, X, Y> : global::NMOLAGMGIFL<Action<T, U, V, W, X, Y>>, global::GBNPNCIMPGD<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x1BAEF20", Offset = "0x1BADF20", VA = "0x181BAEF20")]
	public PPDMDPBDHCF(bool EGMOJIIMFHP = false, bool ECCFKJNMKLD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x2516FC0", Offset = "0x2515FC0", VA = "0x182516FC0")]
	public void JAKEEOPOMIO(T HLNBIKMPIPM, U DIPNKMENNJO, V DCNCBDGEKMD, W NOMPHPBFLNE, X ODLLFOGPPIE, Y GJCOJHOFJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2516BE0", Offset = "0x2515BE0", VA = "0x182516BE0", Slot = "4")]
	public override void IBCOCCDCDEF(object[] GOLEKIJBOAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x2516F20", Offset = "0x2515F20", VA = "0x182516F20")]
	public static global::PPDMDPBDHCF<T, U, V, W, X, Y> IDPFAKACPID(global::PPDMDPBDHCF<T, U, V, W, X, Y> EBJJKPBLHEG, Action<T, U, V, W, X, Y> NCHNGIGODJK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x2517840", Offset = "0x2516840", VA = "0x182517840")]
	public static global::PPDMDPBDHCF<T, U, V, W, X, Y> MMBIJLAKMHD(global::PPDMDPBDHCF<T, U, V, W, X, Y> EBJJKPBLHEG, Action<T, U, V, W, X, Y> NCHNGIGODJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class MPHIKMFJHBH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public readonly struct CJDEBEMGJKM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::MPHIKMFJHBH<T> NPCHBALIDDE;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T FHONEBOCBPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x29FD390", Offset = "0x29FC390", VA = "0x1829FD390")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x29FD3B0", Offset = "0x29FC3B0", VA = "0x1829FD3B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x87A620", Offset = "0x879620", VA = "0x18087A620")]
		public CJDEBEMGJKM(global::MPHIKMFJHBH<T> NPCHBALIDDE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct OKOMEJKLDOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<CJDEBEMGJKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::MPHIKMFJHBH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x2D8C9B0", Offset = "0x2D8B9B0", VA = "0x182D8C9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x2016360", Offset = "0x2015360", VA = "0x182016360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct MEGDLMOFOCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<CJDEBEMGJKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::MPHIKMFJHBH<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3E4CF10", Offset = "0x3E4BF10", VA = "0x183E4CF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2016360", Offset = "0x2015360", VA = "0x182016360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim DACCGNFANOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T MJBGCHFNGKE;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int KALEOOCPAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2A23FB0", Offset = "0x2A22FB0", VA = "0x182A23FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x2A24050", Offset = "0x2A23050", VA = "0x182A24050")]
	public MPHIKMFJHBH(in T MJBGCHFNGKE, int GHDIODBIMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x2A24190", Offset = "0x2A23190", VA = "0x182A24190")]
	public MPHIKMFJHBH(in T MJBGCHFNGKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2A24010", Offset = "0x2A23010", VA = "0x182A24010")]
	public CJDEBEMGJKM JALOJIIANCF()
	{
		return default(CJDEBEMGJKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2A23FD0", Offset = "0x2A22FD0", VA = "0x182A23FD0")]
	public CJDEBEMGJKM JALOJIIANCF(CancellationToken OHJGLBPIBBN)
	{
		return default(CJDEBEMGJKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2A23E50", Offset = "0x2A22E50", VA = "0x182A23E50")]
	[AsyncStateMachine(typeof(global::MPHIKMFJHBH<>.OKOMEJKLDOH))]
	public Task<CJDEBEMGJKM> FDMBJOIDPHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x2A23B70", Offset = "0x2A22B70", VA = "0x182A23B70")]
	[AsyncStateMachine(typeof(global::MPHIKMFJHBH<>.MEGDLMOFOCM))]
	public Task<CJDEBEMGJKM> FDMBJOIDPHN(CancellationToken OHJGLBPIBBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class NKFDHBNDDCB
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2E050", Offset = "0x5D2D050", VA = "0x185D2E050")]
	public static global::MPHIKMFJHBH<FDAEEOMAIHB> AKMEFLONJDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DFE0", Offset = "0x5D2CFE0", VA = "0x185D2DFE0")]
	public static global::MPHIKMFJHBH<FDAEEOMAIHB> AKMEFLONJDG(int GHDIODBIMOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1F2D0B0", Offset = "0x1F2C0B0", VA = "0x181F2D0B0")]
	public static global::MPHIKMFJHBH<T> AKMEFLONJDG<T>(in T MJBGCHFNGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2E755A0", Offset = "0x2E745A0", VA = "0x182E755A0")]
	public static global::MPHIKMFJHBH<T> AKMEFLONJDG<T>(in T MJBGCHFNGKE, int GHDIODBIMOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OMCCPEBFHLA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate Task<TResult> LJFFMFDHIAE(TRequest ANHHADJHMBE, CancellationToken OHJGLBPIBBN);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum JCNBAFMJPEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class LABHJGHDKHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float PMLCCGHHCIB = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan CDGGMGCPBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int OMHCMPAHCPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public JCNBAFMJPEP LKGHGKLALCD;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly LABHJGHDKHN PJLEDACBOPG;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float BOGFENIAEKH
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x1F80A80", Offset = "0x1F7FA80", VA = "0x181F80A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan OKBEPBBDEIL
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x1F80C60", Offset = "0x1F7FC60", VA = "0x181F80C60")]
		public LABHJGHDKHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private readonly struct ANLLJGFJDGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest ANHHADJHMBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken OHJGLBPIBBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> JFGJIKHOIAH;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x324F300", Offset = "0x324E300", VA = "0x18324F300")]
		public ANLLJGFJDGG(TRequest ANHHADJHMBE, TaskCompletionSource<TResult> JFGJIKHOIAH, CancellationToken OHJGLBPIBBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class HMAPDGCEMGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public HMAPDGCEMGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2026530", Offset = "0x2025530", VA = "0x182026530")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct JMAFFOMBNDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::OMCCPEBFHLA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x311DCD0", Offset = "0x311CCD0", VA = "0x18311DCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct GEAMEMBCLAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::OMCCPEBFHLA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ANLLJGFJDGG <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE750", Offset = "0x3EDD750", VA = "0x183EDE750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x652320", Offset = "0x651320", VA = "0x180652320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource NPGMHIOGHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<ANLLJGFJDGG> AIOAGKEAEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly LABHJGHDKHN EOOGICKMFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly LJFFMFDHIAE DIEDPFGECEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task HIIPACJMHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int GGDEIONINLD;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2D908D0", Offset = "0x2D8F8D0", VA = "0x182D908D0")]
	public OMCCPEBFHLA(LJFFMFDHIAE DIEDPFGECEM, [Optional] LABHJGHDKHN EOOGICKMFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F250", Offset = "0x2D8E250", VA = "0x182D8F250")]
	public Task<TResult> ACOEKDJFEPJ(TRequest ANHHADJHMBE, CancellationToken OHJGLBPIBBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x2D904B0", Offset = "0x2D8F4B0", VA = "0x182D904B0")]
	private void JABKEEKOPMA(ANLLJGFJDGG PAONMDKGDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x2D907D0", Offset = "0x2D8F7D0", VA = "0x182D907D0")]
	[AsyncStateMachine(typeof(global::OMCCPEBFHLA<, >.JMAFFOMBNDI))]
	private Task MONLHKCIPOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2D8FF70", Offset = "0x2D8EF70", VA = "0x182D8FF70")]
	private ANLLJGFJDGG FKEDDPMFMCK()
	{
		return default(ANLLJGFJDGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2D8FA80", Offset = "0x2D8EA80", VA = "0x182D8FA80")]
	[AsyncStateMachine(typeof(global::OMCCPEBFHLA<, >.GEAMEMBCLAO))]
	private Task DHNLOECGEEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2D8F0B0", Offset = "0x2D8E0B0", VA = "0x182D8F0B0")]
	private void ACMOJHIMDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x2D8FCC0", Offset = "0x2D8ECC0", VA = "0x182D8FCC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class HGABOONIJBA<TKey, TVal> : global::OKKLELBPLKM<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int GOJHOPOMODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> LNPPEJMJEDP;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int LGFGIEJFHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2692B30", Offset = "0x2691B30", VA = "0x182692B30", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int DHKEKPHEDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x26924B0", Offset = "0x26914B0", VA = "0x1826924B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2692580", Offset = "0x2691580", VA = "0x182692580", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2692B60", Offset = "0x2691B60", VA = "0x182692B60")]
	public HGABOONIJBA(int JAFEKEGLGFD, [Optional] GAOLFALEIGB CFFBBLNCJIB, [Optional] IEqualityComparer<TKey> EPIAJDFJEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x26924E0", Offset = "0x26914E0", VA = "0x1826924E0")]
	public void DEDCIFDKGFE(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF, bool ICJJDLFCOFD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x2692A40", Offset = "0x2691A40", VA = "0x182692A40")]
	public bool KLEADPPOGKC(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x26925E0", Offset = "0x26915E0", VA = "0x1826925E0", Slot = "6")]
	public override bool EPBHELLGDLM(TKey ANFJFPDCAEM, out TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x2692680", Offset = "0x2691680", VA = "0x182692680")]
	public bool GEEMOONNMKA(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x2692890", Offset = "0x2691890", VA = "0x182692890")]
	public bool HNGKFOGDOLL(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x2692AC0", Offset = "0x2691AC0", VA = "0x182692AC0", Slot = "7")]
	public override void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x26929A0", Offset = "0x26919A0", VA = "0x1826929A0")]
	private bool IGJFMLPJNAO(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
[DefaultMember("Item")]
public class OKKLELBPLKM<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate int GAOLFALEIGB(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private class DJBGFGELDPM
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey PIDBPEBBCKL
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0xD92380", Offset = "0xD91380", VA = "0x180D92380")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal FHONEBOCBPE
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x64B130", Offset = "0x64A130", VA = "0x18064B130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int ADODPFDEIHD
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x66C1B0", Offset = "0x66B1B0", VA = "0x18066C1B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x81A8B0", Offset = "0x8198B0", VA = "0x18081A8B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime EPCHOPIAHLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0xE733F0", Offset = "0xE723F0", VA = "0x180E733F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x2E43CA0", Offset = "0x2E42CA0", VA = "0x182E43CA0")]
		public DJBGFGELDPM(TKey AGPLDPOAAIC, TVal OGAPHEEOKGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int PGDGBOPBJMB = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<DJBGFGELDPM>> JCNJOKIICPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<DJBGFGELDPM> DOOPABKFMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly GAOLFALEIGB CFFBBLNCJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan MGOMJKLLFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly DFOOBNHOENJ OHJBCFBOGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int LPFKHGINPIO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MGOGDIHFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x64A020", Offset = "0x649020", VA = "0x18064A020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool PHDEEPDPCEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2D84FD0", Offset = "0x2D83FD0", VA = "0x182D84FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int LGFGIEJFHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x72D090", Offset = "0x72C090", VA = "0x18072D090", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int LGKBEOCJMLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x1F784A0", Offset = "0x1F774A0", VA = "0x181F784A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x232B080", Offset = "0x232A080", VA = "0x18232B080", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> BOJKPFIKJDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2D85060", Offset = "0x2D84060", VA = "0x182D85060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x2D87450", Offset = "0x2D86450", VA = "0x182D87450")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x2D852B0", Offset = "0x2D842B0", VA = "0x182D852B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x2D88550", Offset = "0x2D87550", VA = "0x182D88550")]
	public OKKLELBPLKM(int JAFEKEGLGFD, [Optional] GAOLFALEIGB CFFBBLNCJIB, [Optional] IEqualityComparer<TKey> EPIAJDFJEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x2D880E0", Offset = "0x2D870E0", VA = "0x182D880E0")]
	public OKKLELBPLKM(TimeSpan MGOMJKLLFOB, [Optional] IEqualityComparer<TKey> EPIAJDFJEDH, [Optional] DFOOBNHOENJ OHJBCFBOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x2D87E10", Offset = "0x2D86E10", VA = "0x182D87E10")]
	public OKKLELBPLKM(int JAFEKEGLGFD, TimeSpan MGOMJKLLFOB, [Optional] IEqualityComparer<TKey> EPIAJDFJEDH, [Optional] DFOOBNHOENJ OHJBCFBOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x2D882D0", Offset = "0x2D872D0", VA = "0x182D882D0")]
	public OKKLELBPLKM(int JAFEKEGLGFD, GAOLFALEIGB CFFBBLNCJIB, TimeSpan MGOMJKLLFOB, [Optional] IEqualityComparer<TKey> EPIAJDFJEDH, [Optional] DFOOBNHOENJ OHJBCFBOGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x2D86620", Offset = "0x2D85620", VA = "0x182D86620")]
	public void JCENNMIHJFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D85B60", Offset = "0x2D84B60", VA = "0x182D85B60")]
	public void DIMECELKFHA(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x2D84E60", Offset = "0x2D83E60", VA = "0x182D84E60")]
	public bool ADDEDGCCJIP(TKey AGPLDPOAAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x2D86850", Offset = "0x2D85850", VA = "0x182D86850")]
	private TVal KEEHOGKCDPF(TKey ANFJFPDCAEM)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2D85DC0", Offset = "0x2D84DC0", VA = "0x182D85DC0", Slot = "6")]
	public virtual bool EPBHELLGDLM(TKey ANFJFPDCAEM, out TVal CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2D87490", Offset = "0x2D86490", VA = "0x182D87490", Slot = "7")]
	public virtual void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x2D87150", Offset = "0x2D86150", VA = "0x182D87150")]
	private bool LJNMODDAJLC(DJBGFGELDPM DKAKMJOEBKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x2D87500", Offset = "0x2D86500", VA = "0x182D87500")]
	private void PKLEKPLKJHN(LinkedListNode<DJBGFGELDPM> BLONFKJEAEN, TVal GCFEAMOOPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2D852F0", Offset = "0x2D842F0", VA = "0x182D852F0")]
	private void DIBDKEEBIJK(TKey AGPLDPOAAIC, TVal CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2D86C60", Offset = "0x2D85C60", VA = "0x182D86C60")]
	private void KGAGJPJBEEP(DJBGFGELDPM DKAKMJOEBKG, TVal GCFEAMOOPMJ, int OFPFHBDEIHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[DefaultMember("Item")]
public class EELEHJFJGOP<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> PIJDNOPJENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> KHBEEAKIEHB;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x2026530", Offset = "0x2025530", VA = "0x182026530", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool PEIHLCINDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x64DD00", Offset = "0x64CD00", VA = "0x18064DD00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x20571A0", Offset = "0x20561A0", VA = "0x1820571A0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x2993340", Offset = "0x2992340", VA = "0x182993340", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x2337310", Offset = "0x2336310", VA = "0x182337310", Slot = "11")]
	public void Add(T EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x2992E60", Offset = "0x2991E60", VA = "0x182992E60")]
	public bool KFCNCOMHECF(T EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x29931E0", Offset = "0x29921E0", VA = "0x1829931E0", Slot = "15")]
	public bool Remove(T EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x25BB530", Offset = "0x25BA530", VA = "0x1825BB530", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x2058E70", Offset = "0x2057E70", VA = "0x182058E70", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x2992AA0", Offset = "0x2991AA0", VA = "0x182992AA0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2992B00", Offset = "0x2991B00", VA = "0x182992B00", Slot = "13")]
	public bool Contains(T EKFBJDGFFHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x2056AF0", Offset = "0x2055AF0", VA = "0x182056AF0", Slot = "14")]
	public void CopyTo(T[] KPAFOBEJBIN, int MOIHFCJJBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x27834C0", Offset = "0x27824C0", VA = "0x1827834C0", Slot = "6")]
	public int IndexOf(T EKFBJDGFFHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x2992CD0", Offset = "0x2991CD0", VA = "0x182992CD0", Slot = "7")]
	public void Insert(int MMABPPDCBIB, T EKFBJDGFFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x2993080", Offset = "0x2992080", VA = "0x182993080", Slot = "8")]
	public void RemoveAt(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x2992C00", Offset = "0x2991C00", VA = "0x182992C00")]
	public void FBCBPBLMBPN(Predicate<T> AJKDGHOLKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x2992A70", Offset = "0x2991A70", VA = "0x182992A70")]
	public void AACKGKDDCPN(Comparison<T> IFOABGFNEFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x2993260", Offset = "0x2992260", VA = "0x182993260")]
	public EELEHJFJGOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class KOBCAMDIGIB
{
	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D0E0", Offset = "0x5D2C0E0", VA = "0x185D2D0E0")]
	public static Vector3 KAKGPGIAIBI(this GameObject HBGIADIFHEC, float JJPEEIODEEA)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x2E8E8D0", Offset = "0x2E8D8D0", VA = "0x182E8E8D0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FDB0", Offset = "0x5D2EDB0", VA = "0x185D2FDB0")]
		public SerializedGuid(in Guid PMPGCMIMMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FC50", Offset = "0x5D2EC50", VA = "0x185D2FC50")]
		public static SerializedGuid NPNIGDHEPOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F8D0", Offset = "0x5D2E8D0", VA = "0x185D2F8D0")]
		public static SerializedGuid BHKBFKPNFME()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FBC0", Offset = "0x5D2EBC0", VA = "0x185D2FBC0")]
		public bool KJIIGMAMMJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FD80", Offset = "0x5D2ED80", VA = "0x185D2FD80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FCE0", Offset = "0x5D2ECE0", VA = "0x185D2FCE0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FB20", Offset = "0x5D2EB20", VA = "0x185D2FB20")]
		public bool FMLLLJFHODI(in Guid PMPGCMIMMLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F990", Offset = "0x5D2E990", VA = "0x185D2F990", Slot = "7")]
		public bool Equals(SerializedGuid IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FA40", Offset = "0x5D2EA40", VA = "0x185D2FA40", Slot = "0")]
		public override bool Equals(object ODMJCJPGHNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FBB0", Offset = "0x5D2EBB0", VA = "0x185D2FBB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x5D2F960", Offset = "0x5D2E960", VA = "0x185D2F960", Slot = "6")]
		public int CompareTo(SerializedGuid IIKMMJKCGDO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class BODPKAIDIMP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type BCJLHCAMFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string NOMMOFADICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool NHDKPJIGOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool ABFANCDCEAA;

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AE40", Offset = "0x5D29E40", VA = "0x185D2AE40")]
	public BODPKAIDIMP(Type KEODDAOFGGO, string CJPJHGPMLHD, bool LCGHEKJFNGC = false, bool PBMBOPEBLHO = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface LFAILEJCPCE
{
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface AHMDJHOONLB<T> : LFAILEJCPCE
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool EIGFMBDEHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string APPFLCHEPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::AHMDJHOONLB<T> AEFCJKHDPNK(Action<T> AKCLNHAOBHG);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::AHMDJHOONLB<T> DAGMPELCNAM(Action<T> AKCLNHAOBHG);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::AHMDJHOONLB<T> ALLPCPFHBDC(Action<T, T> CMIAJMOLLPF);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::AHMDJHOONLB<T> MAGIFDLANLF(Action<T, T> CMIAJMOLLPF);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::AHMDJHOONLB<T> BNIKKOFPDPN(Action<string> INNHFKAAFAC);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::AHMDJHOONLB<T> GFPCDGJKKPI(Action<string> INNHFKAAFAC);
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class KKJELACEOOC<T> : global::AHMDJHOONLB<T>, LFAILEJCPCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::DCBNKGAHPLA<T, T> CIHNAHAGMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::DPCNIAMGAEP<T> FDBFGFPGOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::DPCNIAMGAEP<string> DMJFIMFIAJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string OJDKKCJFMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T BBELMPNHPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool OIIOIGHKJKL;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x25A29F0", Offset = "0x25A19F0", VA = "0x1825A29F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool EIGFMBDEHFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x715540", Offset = "0x714540", VA = "0x180715540", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string APPFLCHEPCB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x10BB570", Offset = "0x10BA570", VA = "0x1810BB570", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x30C1C20", Offset = "0x30C0C20", VA = "0x1830C1C20")]
	private void HMGIAJOOMGI(T PLNNMJAODIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x30C1D10", Offset = "0x30C0D10", VA = "0x1830C1D10")]
	private void NIOOJHFGFEG(string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x30C1DC0", Offset = "0x30C0DC0", VA = "0x1830C1DC0")]
	public void PKLFPAMOGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x30C1A70", Offset = "0x30C0A70", VA = "0x1830C1A70", Slot = "6")]
	public global::AHMDJHOONLB<T> ALLPCPFHBDC(Action<T, T> CMIAJMOLLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x30C1CC0", Offset = "0x30C0CC0", VA = "0x1830C1CC0", Slot = "7")]
	public global::AHMDJHOONLB<T> MAGIFDLANLF(Action<T, T> CMIAJMOLLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x30C19E0", Offset = "0x30C09E0", VA = "0x1830C19E0", Slot = "4")]
	public global::AHMDJHOONLB<T> AEFCJKHDPNK(Action<T> CMIAJMOLLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x30C1B60", Offset = "0x30C0B60", VA = "0x1830C1B60", Slot = "5")]
	public global::AHMDJHOONLB<T> DAGMPELCNAM(Action<T> AKCLNHAOBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x30C1AC0", Offset = "0x30C0AC0", VA = "0x1830C1AC0", Slot = "8")]
	public global::AHMDJHOONLB<T> BNIKKOFPDPN(Action<string> INNHFKAAFAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x30C1BB0", Offset = "0x30C0BB0", VA = "0x1830C1BB0", Slot = "9")]
	public global::AHMDJHOONLB<T> GFPCDGJKKPI(Action<string> INNHFKAAFAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x30C1E70", Offset = "0x30C0E70", VA = "0x1830C1E70")]
	public KKJELACEOOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class OHBLJLNBLMP
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class DEDEHDNJJCA<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::AHMDJHOONLB<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::MJBDKPPKHFK<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public DEDEHDNJJCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x3820CA0", Offset = "0x381FCA0", VA = "0x183820CA0")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x2AFCE00", Offset = "0x2AFBE00", VA = "0x182AFCE00")]
	public static global::AGDEEHNAPKP<T> HGMFBEDJIMN<T>(this global::AHMDJHOONLB<T> MAKNKOKDDOA, Action<T> FNAODFKKBJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class BJNCMLEHIAG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public readonly struct LNPAECEJEGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long EIAHNAFDEHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long FGIIAJGNNDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int NMFIFHBNGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int NMPBBBIDKDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool BAEDMNMOCKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string KNCEBOMBPHO;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x2893A60", Offset = "0x2892A60", VA = "0x182893A60")]
		public LNPAECEJEGM(long EIAHNAFDEHI, int NMFIFHBNGND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x2893AD0", Offset = "0x2892AD0", VA = "0x182893AD0")]
		public LNPAECEJEGM(long EIAHNAFDEHI, long FGIIAJGNNDM, int NMFIFHBNGND, int NMPBBBIDKDM, bool BAEDMNMOCKP, string KNCEBOMBPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x28938F0", Offset = "0x28928F0", VA = "0x1828938F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void FDJNMCLKBDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x2893880", Offset = "0x2892880", VA = "0x182893880")]
		public int CAFKNPIMGNF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x28938D0", Offset = "0x28928D0", VA = "0x1828938D0")]
		public int EGMKIACCGBK(int DLFEFDKNEAH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x28939F0", Offset = "0x28929F0", VA = "0x1828939F0")]
		public double LOOBKEDDHKA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2893960", Offset = "0x2892960", VA = "0x182893960")]
		public LNPAECEJEGM ILFKOHEDJFD(long FGIIAJGNNDM, int NMPBBBIDKDM)
		{
			return default(LNPAECEJEGM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class HKLBBGEFPMO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey PIDBPEBBCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::BJNCMLEHIAG<TKey> MDGABGKAFDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<HKLBBGEFPMO> CDLBHKFHOPE;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string FFLCEGPKPGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x2400020", Offset = "0x23FF020", VA = "0x182400020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x23FFD10", Offset = "0x23FED10", VA = "0x1823FFD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<HKLBBGEFPMO> KNPEBNPGMCN
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x23FFD40", Offset = "0x23FED40", VA = "0x1823FFD40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public LNPAECEJEGM KMHNFPHMNJE
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x16C7B80", Offset = "0x16C6B80", VA = "0x1816C7B80")]
			[CompilerGenerated]
			get
			{
				return default(LNPAECEJEGM);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x23FFFF0", Offset = "0x23FEFF0", VA = "0x1823FFFF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x2400050", Offset = "0x23FF050", VA = "0x182400050")]
		internal HKLBBGEFPMO(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, TKey AGPLDPOAAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x23FFC00", Offset = "0x23FEC00", VA = "0x1823FFC00")]
		public HKLBBGEFPMO ADEIHGCDFEB(TKey AGPLDPOAAIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x23FFF10", Offset = "0x23FEF10", VA = "0x1823FFF10")]
		public void EFBOGNCGFEH(TKey AGPLDPOAAIC, Action<HKLBBGEFPMO> NCHNGIGODJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2581100", Offset = "0x2580100", VA = "0x182581100")]
		public T EFBOGNCGFEH<T>(TKey AGPLDPOAAIC, Func<HKLBBGEFPMO, T> LILPACFFGKO)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x2580F90", Offset = "0x257FF90", VA = "0x182580F90")]
		[AsyncStateMachine(typeof(MDLEHCNIPJO))]
		public Task<T> AGGPDBLBDGM<T>(TKey AGPLDPOAAIC, Func<HKLBBGEFPMO, Task<T>> LILPACFFGKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x23FFD60", Offset = "0x23FED60", VA = "0x1823FFD60", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class FMBGLGHAIFI : IEnumerable<(TKey, List<TKey>, LNPAECEJEGM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LNPAECEJEGM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, LNPAECEJEGM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::BJNCMLEHIAG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, LNPAECEJEGM timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, LNPAECEJEGM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x236E570", Offset = "0x236D570", VA = "0x18236E570", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LNPAECEJEGM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x3882340", Offset = "0x3881340", VA = "0x183882340", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x236E7D0", Offset = "0x236D7D0", VA = "0x18236E7D0")]
		[DebuggerHidden]
		public FMBGLGHAIFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x2341820", Offset = "0x2340820", VA = "0x182341820", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3881F90", Offset = "0x3880F90", VA = "0x183881F90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x38823A0", Offset = "0x38813A0", VA = "0x1838823A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3882300", Offset = "0x3881300", VA = "0x183882300", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x3882240", Offset = "0x3881240", VA = "0x183882240", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LNPAECEJEGM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1F7A590", Offset = "0x1F79590", VA = "0x181F7A590", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class NGBONLLHAFA : IEnumerable<(TKey, List<TKey>, LNPAECEJEGM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LNPAECEJEGM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, LNPAECEJEGM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private HKLBBGEFPMO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public HKLBBGEFPMO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::BJNCMLEHIAG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<HKLBBGEFPMO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, LNPAECEJEGM timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, LNPAECEJEGM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x236E570", Offset = "0x236D570", VA = "0x18236E570", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LNPAECEJEGM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x236E610", Offset = "0x236D610", VA = "0x18236E610", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x236E7D0", Offset = "0x236D7D0", VA = "0x18236E7D0")]
		[DebuggerHidden]
		public NGBONLLHAFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x236E670", Offset = "0x236D670", VA = "0x18236E670", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x236DEF0", Offset = "0x236CEF0", VA = "0x18236DEF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x236E710", Offset = "0x236D710", VA = "0x18236E710")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x236E770", Offset = "0x236D770", VA = "0x18236E770")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x236E5D0", Offset = "0x236D5D0", VA = "0x18236E5D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x236E490", Offset = "0x236D490", VA = "0x18236E490", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LNPAECEJEGM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x236E5A0", Offset = "0x236D5A0", VA = "0x18236E5A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, LNPAECEJEGM> DOEBILGGGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, LNPAECEJEGM> GPJGGCIAPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::BJNCMLEHIAG<TKey>> KKOHGLJDFLM;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string LPMFJJDBCLK = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly HKLBBGEFPMO BPFCCAGJGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool GPOGJJAECEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int JOCOENCMDJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch GFEIFEIINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int MONKABKODFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string FBCJFKBFIAC;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public HKLBBGEFPMO EDMCMPMCMAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string FFLCEGPKPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x64A0D0", Offset = "0x6490D0", VA = "0x18064A0D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x277BDB0", Offset = "0x277ADB0", VA = "0x18277BDB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long AEGLNCNFNBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x277C040", Offset = "0x277B040", VA = "0x18277C040")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int LFLKKGCFLOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x277BD80", Offset = "0x277AD80", VA = "0x18277BD80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x277C0E0", Offset = "0x277B0E0", VA = "0x18277C0E0")]
	public BJNCMLEHIAG(TKey FNHCDINDGMP, [Optional] int? NMFIFHBNGND, [Optional][CanBeNull] Stopwatch GFEIFEIINNH, [Optional] Action<TKey, LNPAECEJEGM> DOEBILGGGGH, [Optional] Action<TKey, LNPAECEJEGM> GPJGGCIAPDL, [Optional] Action<global::BJNCMLEHIAG<TKey>> KKOHGLJDFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x277BE30", Offset = "0x277AE30", VA = "0x18277BE30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x277C020", Offset = "0x277B020", VA = "0x18277C020")]
	public void GIIJFBPLAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x277BE10", Offset = "0x277AE10", VA = "0x18277BE10")]
	public void BHAELNLPJNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x277BEC0", Offset = "0x277AEC0", VA = "0x18277BEC0")]
	[IteratorStateMachine(typeof(global::BJNCMLEHIAG<>.FMBGLGHAIFI))]
	public IEnumerable<(TKey, List<TKey>, LNPAECEJEGM)> FDHNMIHJEDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x277BF50", Offset = "0x277AF50", VA = "0x18277BF50")]
	[IteratorStateMachine(typeof(global::BJNCMLEHIAG<>.NGBONLLHAFA))]
	private IEnumerable<(TKey, List<TKey>, LNPAECEJEGM)> FDHNMIHJEDH(List<TKey> OIPMKBNDJIF, HKLBBGEFPMO KEFDBDPEAKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x277C060", Offset = "0x277B060", VA = "0x18277C060")]
	private (long, int) OHMFFEMKPKG()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class BKMMCAIJIPN<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut IOCLGNFAPDI(global::BJNCMLEHIAG<TKey> MDGABGKAFDE);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
	protected BKMMCAIJIPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class GONCNLPPGKG<TKey> : global::BKMMCAIJIPN<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate string CIGHKPDNAAM(TKey AGPLDPOAAIC);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x37A2DC0", Offset = "0x37A1DC0", VA = "0x1837A2DC0")]
	protected string PHKFAOFNMIJ(double BDOOMGDLFLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x37A2E30", Offset = "0x37A1E30", VA = "0x1837A2E30")]
	protected string PHLMDFHJIAF(int OHMMPKKFCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x37A2D80", Offset = "0x37A1D80", VA = "0x1837A2D80")]
	private static string JGMOACDJIBB(TKey AGPLDPOAAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x37A2CD0", Offset = "0x37A1CD0", VA = "0x1837A2CD0", Slot = "4")]
	public override string IOCLGNFAPDI(global::BJNCMLEHIAG<TKey> MDGABGKAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x37A2BA0", Offset = "0x37A1BA0", VA = "0x1837A2BA0")]
	public string IOCLGNFAPDI(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, [NotNull] CIGHKPDNAAM AAJNABKKGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BOLJFIGHNKJ(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, [NotNull] CIGHKPDNAAM AAJNABKKGDK);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x236FF70", Offset = "0x236EF70", VA = "0x18236FF70")]
	protected GONCNLPPGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GCNCAKNNGIJ<TKey> : global::BKMMCAIJIPN<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate string NFBCOBEBDIL(TKey AGPLDPOAAIC);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int KIJDMBPCMOK = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string NNPOMIOKKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double OACNEEOHPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool GJBCCHDHDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int FHAFKLNOIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> NJKOGIKPGPG;

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD430", Offset = "0x3EDC430", VA = "0x183EDD430")]
	private static string JGMOACDJIBB(TKey AGPLDPOAAIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD5F0", Offset = "0x3EDC5F0", VA = "0x183EDD5F0")]
	public GCNCAKNNGIJ(string NNPOMIOKKJH = "F2", double OACNEEOHPJL = double.MaxValue, bool GJBCCHDHDDA = false, int FHAFKLNOIJM = int.MaxValue, [Optional] ISet<string> NJKOGIKPGPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD1D0", Offset = "0x3EDC1D0", VA = "0x183EDD1D0", Slot = "4")]
	public override Dictionary<string, string> IOCLGNFAPDI(global::BJNCMLEHIAG<TKey> MDGABGKAFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3EDCBB0", Offset = "0x3EDBBB0", VA = "0x183EDCBB0")]
	private bool EMOHBPLHECC(string BFOOEFHPOED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3EDCC90", Offset = "0x3EDBC90", VA = "0x183EDCC90")]
	public Dictionary<string, string> IOCLGNFAPDI(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, NFBCOBEBDIL AAJNABKKGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD280", Offset = "0x3EDC280", VA = "0x183EDD280")]
	private string JBAIIKIBDCM(StringBuilder AAJECMHBKEK, List<TKey> IBDMGOKKIIH, NFBCOBEBDIL AAJNABKKGDK, bool GNHNDJMDHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD470", Offset = "0x3EDC470", VA = "0x183EDD470")]
	private static void NIIIMEJIMPJ(StringBuilder FNLJIBFFFED, string NKIACAFOPEC, bool IDNFOMMMPAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class OHLLBLKBDOJ<TKey> : global::GONCNLPPGKG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct MCIANFMPAMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public CIGHKPDNAAM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::OHLLBLKBDOJ<TKey> KGCADEGMLJC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int KPNKHACFCNB = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] KLIMGACBDBE;

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x2D78170", Offset = "0x2D77170", VA = "0x182D78170")]
	private OHLLBLKBDOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x2D77090", Offset = "0x2D76090", VA = "0x182D77090", Slot = "5")]
	protected override string BOLJFIGHNKJ(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, CIGHKPDNAAM AAJNABKKGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x2D77F80", Offset = "0x2D76F80", VA = "0x182D77F80")]
	[CompilerGenerated]
	internal static string CJEOPKDPBKP(string KADCFLNKGNA, TKey AGPLDPOAAIC, ref MCIANFMPAMP P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class PDNOOOCFLKB<TKey> : global::GONCNLPPGKG<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class CCDIALGFEPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public CIGHKPDNAAM keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public CCDIALGFEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x1BAE110", Offset = "0x1BAD110", VA = "0x181BAE110")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x2D24D40", Offset = "0x2D23D40", VA = "0x182D24D40", Slot = "5")]
	protected override string BOLJFIGHNKJ(global::BJNCMLEHIAG<TKey> MDGABGKAFDE, CIGHKPDNAAM AAJNABKKGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x25BB6C0", Offset = "0x25BA6C0", VA = "0x1825BB6C0")]
	public PDNOOOCFLKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public sealed class NDIEDDEPKPJ : global::BJNCMLEHIAG<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class JFOKEAKBKBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<NDIEDDEPKPJ> callback;

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public JFOKEAKBKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2CC30", Offset = "0x5D2BC30", VA = "0x185D2CC30")]
		internal void <Wrap>b__0(global::BJNCMLEHIAG<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DE10", Offset = "0x5D2CE10", VA = "0x185D2DE10")]
	public NDIEDDEPKPJ([Optional] string KCHKKMCHFIH, [Optional] int? NMFIFHBNGND, [Optional] Stopwatch GFEIFEIINNH, [Optional] Action<string, LNPAECEJEGM> DOEBILGGGGH, [Optional] Action<string, LNPAECEJEGM> GPJGGCIAPDL, [Optional] Action<NDIEDDEPKPJ> KKOHGLJDFLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DD30", Offset = "0x5D2CD30", VA = "0x185D2DD30")]
	private static Action<global::BJNCMLEHIAG<string>> EFBOGNCGFEH(Action<NDIEDDEPKPJ> FNAODFKKBJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public abstract class DFOOBNHOENJ
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private class PICEPJLJLBI : DFOOBNHOENJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static DFOOBNHOENJ KGCADEGMLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x5D2E1A0", Offset = "0x5D2D1A0", VA = "0x185D2E1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime EMDDPJGEDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x5D2E150", Offset = "0x5D2D150", VA = "0x185D2E150", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float LLKKFDLMBNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x5D2E140", Offset = "0x5D2D140", VA = "0x185D2E140", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E2A0", Offset = "0x5D2D2A0", VA = "0x185D2E2A0")]
		public PICEPJLJLBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static DFOOBNHOENJ PPPIFNABGAN;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static DFOOBNHOENJ PJLEDACBOPG
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B580", Offset = "0x5D2A580", VA = "0x185D2B580")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime EMDDPJGEDIN
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float LLKKFDLMBNL
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	protected DFOOBNHOENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class FGAIIBJBBMP : global::GNGBMCIEECH<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C1B0", Offset = "0x5D2B1B0", VA = "0x185D2C1B0")]
	public FGAIIBJBBMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GNGBMCIEECH<T> : global::FGIBMGOBPLI<T>, GEGPNHBEGBG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> FJIGFBMOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task EFJHONFPBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x173E7A0", Offset = "0x173D7A0", VA = "0x18173E7A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::AGDEEHNAPKP<T> KCCMHEKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private MLEPGEJLFCO OMHAOGBLAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x10BA2D0", Offset = "0x10B92D0", VA = "0x1810BA2D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x37A1360", Offset = "0x37A0360", VA = "0x1837A1360")]
	public GNGBMCIEECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class IMKJDAPJEAB : global::IMLPLBFJDJP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C680", Offset = "0x5D2B680", VA = "0x185D2C680")]
	public IMKJDAPJEAB(Exception GHAPGMJOMOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class IMLPLBFJDJP<T> : global::FGIBMGOBPLI<T>, GEGPNHBEGBG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> FJIGFBMOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task EFJHONFPBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x173E7A0", Offset = "0x173D7A0", VA = "0x18173E7A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::AGDEEHNAPKP<T> KCCMHEKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private MLEPGEJLFCO OMHAOGBLAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x10BA2D0", Offset = "0x10B92D0", VA = "0x1810BA2D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x2DE52F0", Offset = "0x2DE42F0", VA = "0x182DE52F0")]
	public IMLPLBFJDJP(Exception GHAPGMJOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface GEGPNHBEGBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task FJIGFBMOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	MLEPGEJLFCO KCCMHEKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface FGIBMGOBPLI<T> : GEGPNHBEGBG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> FJIGFBMOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::AGDEEHNAPKP<T> KCCMHEKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class FKGLPOMCPFC<TTask, T> : global::FGIBMGOBPLI<T>, GEGPNHBEGBG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private sealed class ALELFAEDEJN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::FKGLPOMCPFC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public ALELFAEDEJN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool GMLGHDCEHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> IIDIGDMKMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource NLJGOGNMNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool GPOGJJAECEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext FOMFNOLKKGF;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> FJIGFBMOCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task EFJHONFPBPM
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::AGDEEHNAPKP<T> KCCMHEKLNPM
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private MLEPGEJLFCO OMHAOGBLAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x232C390", Offset = "0x232B390", VA = "0x18232C390", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool DHNLGBFLFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x755B40", Offset = "0x754B40", VA = "0x180755B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x387F4E0", Offset = "0x387E4E0", VA = "0x18387F4E0")]
	static FKGLPOMCPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x387F820", Offset = "0x387E820", VA = "0x18387F820")]
	protected FKGLPOMCPFC(TTask IIDIGDMKMIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x387EFD0", Offset = "0x387DFD0", VA = "0x18387EFD0", Slot = "1")]
	~FKGLPOMCPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x387EFA0", Offset = "0x387DFA0", VA = "0x18387EFA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x387F200", Offset = "0x387E200", VA = "0x18387F200")]
	private void PDHGAAMLKHD(bool EJOIIPPLONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T LJMODFCJOJF(TTask HHCOHFMAPEP);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KJHCAMAKIPE();

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x387F040", Offset = "0x387E040", VA = "0x18387F040")]
	[CompilerGenerated]
	private void LMOLHNLLFOC(object KDAIJKFCLIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public interface PIFJCMLEGIB
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float AMAJCMNFOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event NIKMEKEGHNH FMCFBCOHGAD;
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class AKIFNHNILDO : PIFJCMLEGIB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public readonly struct GHICACEIPLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float PNNGHFKIKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float PCGAAFFOKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool DPHKGIJFNKP;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float ADODPFDEIHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x5D2C290", Offset = "0x5D2B290", VA = "0x185D2C290")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C420", Offset = "0x5D2B420", VA = "0x185D2C420")]
		public GHICACEIPLG(float OMKHMNIPPGH, float BDPJJHLGMOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C2A0", Offset = "0x5D2B2A0", VA = "0x185D2C2A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class OCKEGFKDCEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AKIFNHNILDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public OCKEGFKDCEF()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int JAFEKEGLGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int HPCHDAJPBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly PIFJCMLEGIB[] PGJANELEINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly NIKMEKEGHNH[] OHLAEPJHHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly GHICACEIPLG[] PNCAGGPAALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private GHICACEIPLG BIACHIIIGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly CKFJHMPIILJ AHFLGPMEIOI;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public GHICACEIPLG CJJJLACGHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x28FC920", Offset = "0x28FB920", VA = "0x1828FC920")]
		get
		{
			return default(GHICACEIPLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float AMAJCMNFOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5D27ED0", Offset = "0x5D26ED0", VA = "0x185D27ED0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event NIKMEKEGHNH FMCFBCOHGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5D27EF0", Offset = "0x5D26EF0", VA = "0x185D27EF0", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5D27BF0", Offset = "0x5D26BF0", VA = "0x185D27BF0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x5D28000", Offset = "0x5D27000", VA = "0x185D28000")]
	public AKIFNHNILDO(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x5D27CB0", Offset = "0x5D26CB0", VA = "0x185D27CB0")]
	public CKFJHMPIILJ CDLAIHLNHJD(GHICACEIPLG NMJNDGPGMPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x5D27750", Offset = "0x5D26750", VA = "0x185D27750")]
	public void ALKFMJAKLJC(PIFJCMLEGIB FPPKJHIMLIC, [Optional] GHICACEIPLG HKNNAGFHHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5D27FB0", Offset = "0x5D26FB0", VA = "0x185D27FB0")]
	internal int OCHPPPJPAPL(PIFJCMLEGIB CFLBGBODMIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x5D27BA0", Offset = "0x5D26BA0", VA = "0x185D27BA0")]
	internal GHICACEIPLG BHCEDCGILFF(int MMABPPDCBIB)
	{
		return default(GHICACEIPLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5D27D40", Offset = "0x5D26D40", VA = "0x185D27D40", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public delegate void NIKMEKEGHNH(float JGHPCJLFMGN);
[Cpp2IlInjected.Token(Token = "0x2000079")]
internal static class COOGKMCINEN
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float DIKCJJNINAA = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public static class LGEBPCPNCPF
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	private class AEFGPOKHAPO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly PIFJCMLEGIB CFLBGBODMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly NIKMEKEGHNH FNAODFKKBJA;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x5D276C0", Offset = "0x5D266C0", VA = "0x185D276C0")]
		public AEFGPOKHAPO(PIFJCMLEGIB CFLBGBODMIH, NIKMEKEGHNH FNAODFKKBJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5D27670", Offset = "0x5D26670", VA = "0x185D27670", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D3B0", Offset = "0x5D2C3B0", VA = "0x185D2D3B0")]
	internal static bool ENCHCIJGIFK(float DOGOAAONBOH, float ENHIJCCJFBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x49BCDC0", Offset = "0x49BBDC0", VA = "0x1849BCDC0")]
	internal static float LPFCKCBAFFB(float DOGOAAONBOH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D430", Offset = "0x5D2C430", VA = "0x185D2D430")]
	public static IDisposable POEBOEPEOIJ(this PIFJCMLEGIB CFLBGBODMIH, NIKMEKEGHNH FNAODFKKBJA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class CKFJHMPIILJ : PIFJCMLEGIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float JGHPCJLFMGN;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float AMAJCMNFOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x10C9020", Offset = "0x10C8020", VA = "0x1810C9020", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2AF50", Offset = "0x5D29F50", VA = "0x185D2AF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event NIKMEKEGHNH FMCFBCOHGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B010", Offset = "0x5D2A010", VA = "0x185D2B010", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x5D2AEB0", Offset = "0x5D29EB0", VA = "0x185D2AEB0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public CKFJHMPIILJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public static class LHEFBPINJBA
{
	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D560", Offset = "0x5D2C560", VA = "0x185D2D560")]
	[NotNull]
	public static byte[] IFIJDHANMNF(this KPJDGDIGJNP OAAOCIEIAFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D5D0", Offset = "0x5D2C5D0", VA = "0x185D2D5D0")]
	[NotNull]
	public static byte[] IFIJDHANMNF(this KPJDGDIGJNP OAAOCIEIAFG, HashAlgorithmName MCFIBNJOIKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D760", Offset = "0x5D2C760", VA = "0x185D2D760")]
	public static bool MIIPHDNHAHG([CanBeNull] this KPJDGDIGJNP OAAOCIEIAFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D8F0", Offset = "0x5D2C8F0", VA = "0x185D2D8F0")]
	public static bool MIIPHDNHAHG([CanBeNull] this KPJDGDIGJNP OAAOCIEIAFG, out string OJDKKCJFMBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D4F0", Offset = "0x5D2C4F0", VA = "0x185D2D4F0")]
	private static string DEMNAIFENGK([CanBeNull] byte[] CDDAIIMDJCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x5D2D640", Offset = "0x5D2C640", VA = "0x185D2D640")]
	private static bool JKNPBFCDDLH([NotNull] KPJDGDIGJNP OAAOCIEIAFG, [CanBeNull] out byte[] DILDGDHOMIH, [CanBeNull] out byte[] INMNPIJPEAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class APMFDMIANPO
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x5D283B0", Offset = "0x5D273B0", VA = "0x185D283B0")]
	[NotNull]
	public static byte[] IFIJDHANMNF(this EMENMJPDFJB NCOFHLECFIE, byte[] JMMNMEPNPBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5D28180", Offset = "0x5D27180", VA = "0x185D28180")]
	[NotNull]
	public static byte[] IFIJDHANMNF(this EMENMJPDFJB NCOFHLECFIE, HashAlgorithmName MCFIBNJOIKL, byte[] JMMNMEPNPBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public interface EMENMJPDFJB
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash FPALDDOOOME);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface KPJDGDIGJNP : EMENMJPDFJB
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] CMPINFJEEGF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] FHCNCALCCJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object HIHJFPIAJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class BKDJJEMFJOB
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	private class JALPOKBPHJB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C730", Offset = "0x5D2B730", VA = "0x185D2C730")]
		public JALPOKBPHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x5D2C6D0", Offset = "0x5D2B6D0", VA = "0x185D2C6D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte DADLCLOOKJG = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte DCDDOPMALJI = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> BJMHJKDBLOI;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool LHBHCAOCINI;

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x2646330", Offset = "0x2645330", VA = "0x182646330")]
	[Conditional("UNITY_EDITOR")]
	private static void NLAGBCOMOED<T>(params T[] NKGLGEEIDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A5C0", Offset = "0x5D295C0", VA = "0x185D2A5C0")]
	public static IDisposable FGKCEBBCDME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A4D0", Offset = "0x5D294D0", VA = "0x185D2A4D0")]
	public static void ENFONHNGHAF(this IncrementalHash LNBHNBAENDB, [CanBeNull] GameObject HBGIADIFHEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x2645D70", Offset = "0x2644D70", VA = "0x182645D70")]
	public static void ENFONHNGHAF<T>(this IncrementalHash LNBHNBAENDB, [CanBeNull] T CHHHDNBJJIO) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x2645E40", Offset = "0x2644E40", VA = "0x182645E40")]
	public static void NFFBNAAJJGF<T>(this IncrementalHash LNBHNBAENDB, [CanBeNull] T NCOFHLECFIE) where T : EMENMJPDFJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x2645ED0", Offset = "0x2644ED0", VA = "0x182645ED0")]
	public static void NJPJJKAOFIE<T>(this IncrementalHash LNBHNBAENDB, [CanBeNull] IList<T> BIPCDPIJBPC) where T : EMENMJPDFJB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A730", Offset = "0x5D29730", VA = "0x185D2A730")]
	private static bool HHFLDIIELHH([CanBeNull] EMENMJPDFJB NCOFHLECFIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A660", Offset = "0x5D29660", VA = "0x185D2A660")]
	public static void FLNBHFPDBIJ(this IncrementalHash FPALDDOOOME, [CanBeNull] string OBNGFNJHKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A300", Offset = "0x5D29300", VA = "0x185D2A300")]
	public static void DOMCPMKMGHD(this IncrementalHash FPALDDOOOME, long FNLGLEICPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A820", Offset = "0x5D29820", VA = "0x185D2A820")]
	public static void JHAJJIMHLFC(this IncrementalHash FPALDDOOOME, int BDPKOABHKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5D29CD0", Offset = "0x5D28CD0", VA = "0x185D29CD0")]
	public static void BHOMOANMNBK(this IncrementalHash FPALDDOOOME, short BOCPNHKEPPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A9F0", Offset = "0x5D299F0", VA = "0x185D2A9F0")]
	public static void LLNPAJGKDLP(this IncrementalHash FPALDDOOOME, byte EPIAEKKNOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A0D0", Offset = "0x5D290D0", VA = "0x185D2A0D0")]
	public static void DEOANDFALBN(this IncrementalHash FPALDDOOOME, bool HBAIMOMFGGB, bool HCBBLGMLJNH = false, bool LCDDDJNFILG = false, bool NKAFFDGCABC = false, bool BEIGJDNLIOE = false, bool LIDFMKGDJAI = false, bool DBPJADEJBCE = false, bool ALCEMJBEMAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x2645680", Offset = "0x2644680", VA = "0x182645680")]
	public static void EFGEJGIBEIF<T>(this IncrementalHash FPALDDOOOME, T GKMCJJIMLBK) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D2ACD0", Offset = "0x5D29CD0", VA = "0x185D2ACD0")]
	public static void PECBLKDJKKO(this IncrementalHash FPALDDOOOME, float DDBDCGCCAMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A7C0", Offset = "0x5D297C0", VA = "0x185D2A7C0")]
	public static void IAJOCOIGHIN(this IncrementalHash FPALDDOOOME, double EMJADNBAEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D29EA0", Offset = "0x5D28EA0", VA = "0x185D29EA0")]
	public static void BMDPEHBPNKA(this IncrementalHash FPALDDOOOME, ulong LIDFLJDNAIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A2A0", Offset = "0x5D292A0", VA = "0x185D2A2A0")]
	public static void DHGNCNMPNIN(this IncrementalHash FPALDDOOOME, uint ABHEDMODIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A6C0", Offset = "0x5D296C0", VA = "0x185D2A6C0")]
	public static void GNNNKLAPLGG(this IncrementalHash FPALDDOOOME, ushort LGLODLCLONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AB60", Offset = "0x5D29B60", VA = "0x185D2AB60")]
	public static void MOBECALLLMO(this IncrementalHash FPALDDOOOME, Vector3 GALABPAIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x5D29F10", Offset = "0x5D28F10", VA = "0x185D29F10")]
	public static void CHIPPGOLHME(this IncrementalHash FPALDDOOOME, Quaternion FFHCCELDPMK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public class KJAOIBGKBMH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type BCJLHCAMFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string NOMMOFADICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool NHDKPJIGOHG;

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CEC0", Offset = "0x5D2BEC0", VA = "0x185D2CEC0")]
	public KJAOIBGKBMH(Type KEODDAOFGGO, string CJPJHGPMLHD, bool LCGHEKJFNGC = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class MGDEKNPNGNN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DC40", Offset = "0x5D2CC40", VA = "0x185D2DC40")]
	public MGDEKNPNGNN(string NJAIIGFCHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DCB0", Offset = "0x5D2CCB0", VA = "0x185D2DCB0")]
	public MGDEKNPNGNN(string NJAIIGFCHNG, Exception COLLJDCIAGM)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x64A040", Offset = "0x649040", VA = "0x18064A040")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x660790", Offset = "0x65F790", VA = "0x180660790")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int GBIDHHJLPLE, int AOFKHJEAGOP]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x3919F70", Offset = "0x3918F70", VA = "0x183919F70")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x391A010", Offset = "0x3919010", VA = "0x18391A010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x3919EE0", Offset = "0x3918EE0", VA = "0x183919EE0")]
		public Array2D(uint BHAMBKDMALL, uint PEJBJHOOMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x3919E60", Offset = "0x3918E60", VA = "0x183919E60")]
		public void OJEEPLKEKIC()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D283F0", Offset = "0x5D273F0", VA = "0x185D283F0")]
		public Array2DVector3(uint BHAMBKDMALL, uint PEJBJHOOMHE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
internal static class LGKKCNPIIMD
{
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public const int BPBAJLJEJPB = -1;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int FJANNPFDFEB = 0;
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[DefaultMember("Item")]
public class PCNAFPCNLFL<THandle, TValue> : IDisposable where THandle : struct, EKJNBJHBEDB where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private readonly List<THandle> ICIEPJPHBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<TValue> JIECDBDFHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly Func<TValue> MLIBGLACIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Action<TValue> NJNKEBCCAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int KKKCNMNGFLH;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x2782740", Offset = "0x2781740", VA = "0x182782740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x2D22C90", Offset = "0x2D21C90", VA = "0x182D22C90")]
	public PCNAFPCNLFL(Action<TValue> NJNKEBCCAIO, [Optional] Func<TValue> MLIBGLACIED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x2D223A0", Offset = "0x2D213A0", VA = "0x182D223A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x3214B60", Offset = "0x3213B60", VA = "0x183214B60")]
	public THandle MFNJFAEBAIM()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2D22330", Offset = "0x2D21330", VA = "0x182D22330")]
	public THandle CEMPCIEDPMO(TValue CCIMHDCKHOF)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2D221B0", Offset = "0x2D211B0", VA = "0x182D221B0")]
	public bool ADDEDGCCJIP(THandle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x2D22260", Offset = "0x2D21260", VA = "0x182D22260")]
	public bool BCKCNDMGJOA(THandle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x2D22A80", Offset = "0x2D21A80", VA = "0x182D22A80")]
	public bool MFJHFJBDKOG(THandle BLIPNDKFLPL, out TValue CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x2D22950", Offset = "0x2D21950", VA = "0x182D22950")]
	public TValue KEEHOGKCDPF(THandle BLIPNDKFLPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x2D22460", Offset = "0x2D21460", VA = "0x182D22460")]
	public bool FKKMCEBMOMF(THandle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x2D22C60", Offset = "0x2D21C60", VA = "0x182D22C60")]
	private THandle OGIPDGPKNKP(int MMABPPDCBIB)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x2D22640", Offset = "0x2D21640", VA = "0x182D22640")]
	private TValue HGMFBEDJIMN(int MMABPPDCBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x2D22420", Offset = "0x2D21420", VA = "0x182D22420")]
	private void FKEEFHFPMPH(int MMABPPDCBIB, in THandle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x2D22670", Offset = "0x2D21670", VA = "0x182D22670")]
	private void HMGIAJOOMGI(int MMABPPDCBIB, in TValue CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x2D22830", Offset = "0x2D21830", VA = "0x182D22830")]
	private THandle JDBIILFODCP()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x2D226B0", Offset = "0x2D216B0", VA = "0x182D226B0")]
	private void IDCJMPGNFPD(THandle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x2D22510", Offset = "0x2D21510", VA = "0x182D22510")]
	private int GBGMCMPJLIE(int LDFDMKAILBI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x2D22940", Offset = "0x2D21940", VA = "0x182D22940")]
	private bool JLOIFEFNIEL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x6B1640", Offset = "0x6B0640", VA = "0x1806B1640")]
	private void PFNOCCMODHO(THandle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2D22A00", Offset = "0x2D21A00", VA = "0x182D22A00")]
	private bool MDIPPBOFJDK(out THandle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2D22760", Offset = "0x2D21760", VA = "0x182D22760")]
	private bool IFNCCOFHMIB(out THandle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x2D229A0", Offset = "0x2D219A0", VA = "0x182D229A0")]
	private void LKIAKKCEFCL(THandle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x2D22520", Offset = "0x2D21520", VA = "0x182D22520")]
	private void GDLIDGKJKKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface EKJNBJHBEDB
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int DCEMEBHPCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int ONIBILKIFBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface KIMFBICNHMN<T> : EKJNBJHBEDB, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
public static class MBIHNIBGDCN
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xDAA9E0", Offset = "0xDA99E0", VA = "0x180DAA9E0")]
	public static bool HFGEKIMGMLB<T>(this T BLIPNDKFLPL, T IIKMMJKCGDO) where T : struct, EKJNBJHBEDB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x27FFD20", Offset = "0x27FED20", VA = "0x1827FFD20")]
	public static bool DPHKGIJFNKP<T>(this T BLIPNDKFLPL) where T : struct, EKJNBJHBEDB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2DB30", Offset = "0x5D2CB30", VA = "0x185D2DB30")]
	public static string FOJDKKAOGCC(this EKJNBJHBEDB BLIPNDKFLPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public class BGPJHHFDKPH
{
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	private enum DDEIGLEGOEH : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int FPALDDOOOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool ELOBMNMCOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private DDEIGLEGOEH JCLIGOJKKCI;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool GFAFPPNCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x5D28ED0", Offset = "0x5D27ED0", VA = "0x185D28ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool NHCJKDFHINB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x5D28F00", Offset = "0x5D27F00", VA = "0x185D28F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D29CA0", Offset = "0x5D28CA0", VA = "0x185D29CA0")]
	public BGPJHHFDKPH(bool ELOBMNMCOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D28F50", Offset = "0x5D27F50", VA = "0x185D28F50")]
	public void JBJIHFNDAAI(object ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5D299B0", Offset = "0x5D289B0", VA = "0x185D299B0")]
	public void MCEPPKCLLOO(int CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x5D29C00", Offset = "0x5D28C00", VA = "0x185D29C00")]
	public void OLIENJBOHBF(uint CDBPCPCHNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x5D28EE0", Offset = "0x5D27EE0", VA = "0x185D28EE0")]
	public void BMPLJMHJLGI(bool ENMIGOJBPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5D28E90", Offset = "0x5D27E90", VA = "0x185D28E90")]
	public void BFKAECJHAIJ(long LENMDADPBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5D28F10", Offset = "0x5D27F10", VA = "0x185D28F10")]
	public void FGHENJOJMLC(ulong JJEBJOIFMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5D28E20", Offset = "0x5D27E20", VA = "0x185D28E20")]
	public void ALEFCLEKFMP(string LILNHPOEIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5D29C10", Offset = "0x5D28C10", VA = "0x185D29C10")]
	public void PHKLEIFHIDD(Enum GHAPGMJOMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5D29AC0", Offset = "0x5D28AC0", VA = "0x185D29AC0")]
	public void NANJPNHKKFL(IList PIJDNOPJENO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x2642800", Offset = "0x2641800", VA = "0x182642800")]
	public void FGKBKAOHFEN<T, U>(Dictionary<T, U> FOHJGKGDGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5D29640", Offset = "0x5D28640", VA = "0x185D29640")]
	private void LNDOMHJHCME(IDictionary FOHJGKGDGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5D29A50", Offset = "0x5D28A50", VA = "0x185D29A50")]
	public int MKPMAPDLMGK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x5D295D0", Offset = "0x5D285D0", VA = "0x185D295D0")]
	public short LJJHHGIPCHC()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5D29BF0", Offset = "0x5D28BF0", VA = "0x185D29BF0")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5D28DB0", Offset = "0x5D27DB0", VA = "0x185D28DB0")]
	private void AGAINJMHIHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public abstract class MMINGHEIDKP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	internal class FALGNDCEIDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public TNode IPNNIJODOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode OJKLIAPCMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public LABGBGAMKBM BJIDGGBJEAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public List<LABGBGAMKBM> MHDHNDIGAAC;

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		public FALGNDCEIDD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	internal struct LABGBGAMKBM : IComparable<LABGBGAMKBM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public int PCMCGMOPFKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public TClaimant DGCMJEEHDPF;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x6750B0", Offset = "0x6740B0", VA = "0x1806750B0")]
		public LABGBGAMKBM(int PCMCGMOPFKB, TClaimant DGCMJEEHDPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1F80920", Offset = "0x1F7F920", VA = "0x181F80920")]
		public bool ABNIDMILELH(in LABGBGAMKBM IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1F80990", Offset = "0x1F7F990", VA = "0x181F80990")]
		public bool ODBBINLMAKP(in LABGBGAMKBM IIKMMJKCGDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1F80980", Offset = "0x1F7F980", VA = "0x181F80980", Slot = "4")]
		public int CompareTo(LABGBGAMKBM IIKMMJKCGDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1F809A0", Offset = "0x1F7F9A0", VA = "0x181F809A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum KFGECDIBHDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ICPBIDAHEDD : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public global::MMINGHEIDKP<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1BB6460", Offset = "0x1BB5460", VA = "0x181BB6460")]
		[DebuggerHidden]
		public ICPBIDAHEDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1BB6260", Offset = "0x1BB5260", VA = "0x181BB6260", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1BB6420", Offset = "0x1BB5420", VA = "0x181BB6420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1BB6340", Offset = "0x1BB5340", VA = "0x181BB6340", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x10B87D0", Offset = "0x10B77D0", VA = "0x1810B87D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly global::DJCLGKPCLBB<FALGNDCEIDD> JFHHNBGNOPF;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::DJCLGKPCLBB<List<LABGBGAMKBM>> NACIDCFAEOC;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int MLCOOELGOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	internal readonly Dictionary<TClaimant, TNode> AIAPFKCDEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TNode, FALGNDCEIDD> ABJCMJMCOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private KFGECDIBHDI PDFIDNNGANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private bool KAIBIFDFALJ;

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GECBLHBNBIF(TNode CBLFDLDNPMN);

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void GAFMNHLEAFA(TNode CBLFDLDNPMN, TClaimant KFNMBHJBCME, TClaimant GMMMAFBCANF);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x3332E30", Offset = "0x3331E30", VA = "0x183332E30")]
	public MMINGHEIDKP(KFGECDIBHDI PDFIDNNGANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3332100", Offset = "0x3331100", VA = "0x183332100")]
	public void FJNPBAEFMLA(TNode CBLFDLDNPMN, TNode ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x3332A10", Offset = "0x3331A10", VA = "0x183332A10")]
	public void JGELGMBBBEG(TClaimant DGCMJEEHDPF, TNode DLCADIDKAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x3331B30", Offset = "0x3330B30", VA = "0x183331B30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x3331870", Offset = "0x3330870", VA = "0x183331870")]
	private void AOGEABNOHAK(TClaimant DGCMJEEHDPF, TNode JLABDGOECNH, TNode DLCADIDKAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x3332C70", Offset = "0x3331C70", VA = "0x183332C70")]
	private int OHEOAFMJLBH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x3332760", Offset = "0x3331760", VA = "0x183332760")]
	private void ILEHLAABGLC(TClaimant DGCMJEEHDPF, TNode NBDFMIMNLBD, TNode POADJDFNECJ, int KPPHIIJAGAH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x3332BE0", Offset = "0x3331BE0", VA = "0x183332BE0")]
	private void LIEBEINHLKL(LABGBGAMKBM HALCEDGDBGP, FALGNDCEIDD OBJIBHDLDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3332180", Offset = "0x3331180", VA = "0x183332180")]
	private void GFFAKDCGAEB(TClaimant DGCMJEEHDPF, TNode NBDFMIMNLBD, TNode POADJDFNECJ, int KPPHIIJAGAH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x3331A20", Offset = "0x3330A20", VA = "0x183331A20")]
	private void DNINIDIIPGD(LABGBGAMKBM HALCEDGDBGP, TNode CBLFDLDNPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x33324A0", Offset = "0x33314A0", VA = "0x1833324A0")]
	private void HLNBEDEJHCG(LABGBGAMKBM HALCEDGDBGP, FALGNDCEIDD OBJIBHDLDKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x3331910", Offset = "0x3330910", VA = "0x183331910")]
	private void BANDGLPFJAN(FALGNDCEIDD OBJIBHDLDKG, bool GHCANGIEKHL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3331D90", Offset = "0x3330D90", VA = "0x183331D90")]
	private void EBAKAAKBBPF(FALGNDCEIDD OBJIBHDLDKG, TNode ILIAKNFOPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x3332B10", Offset = "0x3331B10", VA = "0x183332B10")]
	[IteratorStateMachine(typeof(global::MMINGHEIDKP<, >.ICPBIDAHEDD))]
	private IEnumerable<TNode> JMOACFAAECH(TNode NBDFMIMNLBD, TNode POADJDFNECJ, bool FDGAFGHBAHK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x33323E0", Offset = "0x33313E0", VA = "0x1833323E0")]
	private FALGNDCEIDD GNHPFCCNGHH(TNode CBLFDLDNPMN, TNode OJKLIAPCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x33316E0", Offset = "0x33306E0", VA = "0x1833316E0")]
	private FALGNDCEIDD AANDAFLNEKN(TNode CBLFDLDNPMN, TNode OJKLIAPCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x33325A0", Offset = "0x33315A0", VA = "0x1833325A0")]
	private void IHLINLJMPGN(FALGNDCEIDD OBJIBHDLDKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public class LMKLFAIBJID<T> : IEnumerable<global::LMKLFAIBJID<T>.IMHFCBKOGIC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public struct IMHFCBKOGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public T CCIMHDCKHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public int MMABPPDCBIB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class FBPFEEDMIFN : IEnumerator<IMHFCBKOGIC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private global::LMKLFAIBJID<T> OOOLCIHHFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private int MMABPPDCBIB;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x10AC8F0", Offset = "0x10AB8F0", VA = "0x1810AC8F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public IMHFCBKOGIC IKECDOHOPGM
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x25ACC60", Offset = "0x25ABC60", VA = "0x1825ACC60", Slot = "4")]
			get
			{
				return default(IMHFCBKOGIC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x64E060", Offset = "0x64D060", VA = "0x18064E060")]
		public FBPFEEDMIFN(global::LMKLFAIBJID<T> OOOLCIHHFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x25ACBE0", Offset = "0x25ABBE0", VA = "0x1825ACBE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x64E050", Offset = "0x64D050", VA = "0x18064E050", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x88B660", Offset = "0x88A660", VA = "0x18088B660", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000098")]
	private struct FAJKPNAALKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public bool LDLJNLMJDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public T CCIMHDCKHOF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private const int OGGJBEHPLKI = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Dictionary<T, int> AFFMDBFIEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private FAJKPNAALKB[] LLIHGMLIDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private int MKAIEPFIJNN;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int FOCGBJNEJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x66AD90", Offset = "0x669D90", VA = "0x18066AD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x837950", Offset = "0x836950", VA = "0x180837950")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x2026530", Offset = "0x2025530", VA = "0x182026530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x2892260", Offset = "0x2891260", VA = "0x182892260")]
	public LMKLFAIBJID(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x2891A80", Offset = "0x2890A80", VA = "0x182891A80")]
	public LMKLFAIBJID(IMHFCBKOGIC[] EDKOFDEAJAI, bool PAIPMGNEBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x2891520", Offset = "0x2890520", VA = "0x182891520")]
	public int NCIKCKDAMPI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x2891780", Offset = "0x2890780", VA = "0x182891780")]
	private int NCLEMPKJJFN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x2890A10", Offset = "0x288FA10", VA = "0x182890A10", Slot = "6")]
	protected virtual uint EDMBNPDCFGI(uint FPALDDOOOME, T CCIMHDCKHOF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x28914B0", Offset = "0x28904B0", VA = "0x1828914B0")]
	public bool MJGCLNLKPKE(T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x2890FA0", Offset = "0x288FFA0", VA = "0x182890FA0")]
	public bool IIHPGIKGAMM(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x2890850", Offset = "0x288F850", VA = "0x182890850")]
	public bool CBBIGPLMGHA(Func<T, bool> KBGJCMKGEHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x2890740", Offset = "0x288F740", VA = "0x182890740")]
	public int BLONAIJHGEF(T CCIMHDCKHOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x2890C30", Offset = "0x288FC30", VA = "0x182890C30")]
	public T HGMFBEDJIMN(int MMABPPDCBIB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x2891980", Offset = "0x2890980", VA = "0x182891980")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x2891040", Offset = "0x2890040", VA = "0x182891040")]
	public bool KFCNCOMHECF(T CCIMHDCKHOF, bool JGBAHGMLCOB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x28910B0", Offset = "0x28900B0", VA = "0x1828910B0")]
	public bool KFCNCOMHECF(T CCIMHDCKHOF, int MMABPPDCBIB, bool JGBAHGMLCOB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x2890660", Offset = "0x288F660", VA = "0x182890660")]
	public bool ADDEDGCCJIP(T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x28909C0", Offset = "0x288F9C0", VA = "0x1828909C0")]
	public bool CLBKMDGGMLI(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x2890A60", Offset = "0x288FA60", VA = "0x182890A60")]
	private void GMMBBPAKCJJ(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x2890E60", Offset = "0x288FE60", VA = "0x182890E60")]
	public IMHFCBKOGIC[] HHOLENPNECD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2890970", Offset = "0x288F970", VA = "0x182890970")]
	private int CKPAFEEEDBG(int OFHLFABGMBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x2891A00", Offset = "0x2890A00", VA = "0x182891A00", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x2891A00", Offset = "0x2890A00", VA = "0x182891A00", Slot = "4")]
	private IEnumerator<IMHFCBKOGIC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public struct BBNCPEJIGGM<Handle> where Handle : EKJNBJHBEDB, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	private struct PCOMJKNOCPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private readonly global::BBNCPEJIGGM<Handle> FGMDHCGBMCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private int MMABPPDCBIB;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int HEINJKEDNCP
		{
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x2D23500", Offset = "0x2D22500", VA = "0x182D23500")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle FDJFILPPINB
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x2D23AC0", Offset = "0x2D22AC0", VA = "0x182D23AC0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x2D24080", Offset = "0x2D23080", VA = "0x182D24080")]
		public PCOMJKNOCPB(global::BBNCPEJIGGM<Handle> FGMDHCGBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x2D23020", Offset = "0x2D22020", VA = "0x182D23020")]
		public EOFPMIPKDAN AKMEFLONJDG(in EOFPMIPKDAN NJKKDANCIMG)
		{
			return default(EOFPMIPKDAN);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x2D22F80", Offset = "0x2D21F80", VA = "0x182D22F80")]
		public AAHKHCEDBCC AKMEFLONJDG(in AAHKHCEDBCC NJKKDANCIMG)
		{
			return default(AAHKHCEDBCC);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x2D237C0", Offset = "0x2D227C0", VA = "0x182D237C0")]
		public bool GNBAAEFDOKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x2D230C0", Offset = "0x2D220C0", VA = "0x182D230C0")]
		private int DIABLHNGMFA(string NJAIIGFCHNG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x2D23980", Offset = "0x2D22980", VA = "0x182D23980")]
		private Handle KIECJCJAPDJ(string NJAIIGFCHNG)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public struct EOFPMIPKDAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private PCOMJKNOCPB KABGDGCHNPF;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int IKECDOHOPGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x2061D50", Offset = "0x2060D50", VA = "0x182061D50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x2061E10", Offset = "0x2060E10", VA = "0x182061E10")]
		public EOFPMIPKDAN(global::BBNCPEJIGGM<Handle> FGMDHCGBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x2061C90", Offset = "0x2060C90", VA = "0x182061C90")]
		public bool GNBAAEFDOKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x2061B90", Offset = "0x2060B90", VA = "0x182061B90")]
		public EOFPMIPKDAN CDEDLLPMOKO()
		{
			return default(EOFPMIPKDAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct AAHKHCEDBCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private PCOMJKNOCPB KABGDGCHNPF;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle IKECDOHOPGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x26C92E0", Offset = "0x26C82E0", VA = "0x1826C92E0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x2061E10", Offset = "0x2060E10", VA = "0x182061E10")]
		public AAHKHCEDBCC(global::BBNCPEJIGGM<Handle> FGMDHCGBMCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x2061C90", Offset = "0x2060C90", VA = "0x182061C90")]
		public bool GNBAAEFDOKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x26C91E0", Offset = "0x26C81E0", VA = "0x1826C91E0")]
		public AAHKHCEDBCC CDEDLLPMOKO()
		{
			return default(AAHKHCEDBCC);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private NativeList<int> GKJHJGAAPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> PLALPILABFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int KKIGHFHJOEM;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool KJFIOINAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x4263D40", Offset = "0x4262D40", VA = "0x184263D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int MGOGDIHFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x4262480", Offset = "0x4261480", VA = "0x184262480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int NJCEGBJDCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x64A010", Offset = "0x649010", VA = "0x18064A010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int GCGAJKJJHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x64A010", Offset = "0x649010", VA = "0x18064A010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public EOFPMIPKDAN GKADFMHLEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x4264C00", Offset = "0x4263C00", VA = "0x184264C00")]
		get
		{
			return default(EOFPMIPKDAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AAHKHCEDBCC FMFGMOEBNNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x4264CA0", Offset = "0x4263CA0", VA = "0x184264CA0")]
		get
		{
			return default(AAHKHCEDBCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x42667F0", Offset = "0x42657F0", VA = "0x1842667F0")]
	public BBNCPEJIGGM(int EJADEEOGECD, Allocator EGJIMBMGFGA = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x42664F0", Offset = "0x42654F0", VA = "0x1842664F0")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x14D0AF0", Offset = "0x14CFAF0", VA = "0x1814D0AF0")]
	public static int GBGMCMPJLIE(int DCNCBDGEKMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x4265CA0", Offset = "0x4264CA0", VA = "0x184265CA0")]
	public static bool MPAGBCOCLII(int DCNCBDGEKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x4266740", Offset = "0x4265740", VA = "0x184266740")]
	public static bool PMBAPJKEPME(int DCNCBDGEKMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x4265FE0", Offset = "0x4264FE0", VA = "0x184265FE0")]
	public bool NFNPJJGCGDN(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x4263880", Offset = "0x4262880", VA = "0x184263880")]
	public bool DDJFDLDPNHA(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x4265460", Offset = "0x4264460", VA = "0x184265460")]
	public bool LACABJDKKBH(Handle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x4263570", Offset = "0x4262570", VA = "0x184263570")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void DADAGEOKFLI(Handle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x4265A90", Offset = "0x4264A90", VA = "0x184265A90")]
	public Handle MFDIBGBKELB()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x4264360", Offset = "0x4263360", VA = "0x184264360")]
	public void EJICNPDKIGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x4265240", Offset = "0x4264240", VA = "0x184265240")]
	public void KOJGCEODHCF(Handle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x4265940", Offset = "0x4264940", VA = "0x184265940")]
	public bool LEGHBPLGEIF(Handle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x4266620", Offset = "0x4265620", VA = "0x184266620")]
	private bool PFFDMIOFFMI(int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x4262580", Offset = "0x4261580", VA = "0x184262580")]
	private void AFHKAJMBHEI(out int MMABPPDCBIB, out int LDFDMKAILBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x4264FA0", Offset = "0x4263FA0", VA = "0x184264FA0")]
	private void JONABJLBEIM(Handle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x4262BE0", Offset = "0x4261BE0", VA = "0x184262BE0")]
	private void COOMLIIFOLJ(int MMABPPDCBIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x4264B50", Offset = "0x4263B50", VA = "0x184264B50")]
	private bool ELLBNFMLDAN(out int MMABPPDCBIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x42660F0", Offset = "0x42650F0", VA = "0x1842660F0")]
	private static Handle NLJNEECFAFF(int MMABPPDCBIB, int LDFDMKAILBI)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[DefaultMember("Item")]
public struct KNEIBAGCIPL<Handle, T> where Handle : EKJNBJHBEDB, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private global::BBNCPEJIGGM<Handle> JGOGKCIEEIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private T[] LOHJIBBFOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private Action<T> BOGNLPPFCAH;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool KJFIOINAPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x30CB2F0", Offset = "0x30CA2F0", VA = "0x1830CB2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int MGOGDIHFDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x30CA280", Offset = "0x30C9280", VA = "0x1830CA280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x30CBAF0", Offset = "0x30CAAF0", VA = "0x1830CBAF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T ICEOJCBPDOD
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x30CC780", Offset = "0x30CB780", VA = "0x1830CC780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x30CD600", Offset = "0x30CC600", VA = "0x1830CD600")]
	public KNEIBAGCIPL(int EJADEEOGECD, [Optional] Action<T> BOGNLPPFCAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x30CD450", Offset = "0x30CC450", VA = "0x1830CD450")]
	public void PDHGAAMLKHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x30CC5D0", Offset = "0x30CB5D0", VA = "0x1830CC5D0")]
	public bool LACABJDKKBH(Handle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void DADAGEOKFLI(Handle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x30CC420", Offset = "0x30CB420", VA = "0x1830CC420")]
	public T KEEHOGKCDPF(Handle BLIPNDKFLPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x30CC890", Offset = "0x30CB890", VA = "0x1830CC890")]
	public bool MFJHFJBDKOG(Handle BLIPNDKFLPL, out T ODMJCJPGHNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x30CB020", Offset = "0x30CA020", VA = "0x1830CB020")]
	public void DIMECELKFHA(Handle BLIPNDKFLPL, T GGEEEEGHELO, out T BHEJIMJPPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x30CB0C0", Offset = "0x30CA0C0", VA = "0x1830CB0C0")]
	public void DIMECELKFHA(Handle BLIPNDKFLPL, T GGEEEEGHELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x30CCE90", Offset = "0x30CBE90", VA = "0x1830CCE90")]
	public bool MOPEIKOLPCO(Handle BLIPNDKFLPL, T GGEEEEGHELO, out T BHEJIMJPPMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x30CD160", Offset = "0x30CC160", VA = "0x1830CD160")]
	public bool MOPEIKOLPCO(Handle BLIPNDKFLPL, T GGEEEEGHELO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x30CAB40", Offset = "0x30C9B40", VA = "0x1830CAB40")]
	public Handle CEMPCIEDPMO(T ODMJCJPGHNI)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x30CC1E0", Offset = "0x30CB1E0", VA = "0x1830CC1E0")]
	public void FBCBPBLMBPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x30CA5F0", Offset = "0x30C95F0", VA = "0x1830CA5F0")]
	public void ADDEDGCCJIP(Handle BLIPNDKFLPL, out T BHEJIMJPPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x30CA380", Offset = "0x30C9380", VA = "0x1830CA380")]
	public void ADDEDGCCJIP(Handle BLIPNDKFLPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x30CB4D0", Offset = "0x30CA4D0", VA = "0x1830CB4D0")]
	public bool EJPELPJHBEE(Handle BLIPNDKFLPL, out T BHEJIMJPPMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x30CB850", Offset = "0x30CA850", VA = "0x1830CB850")]
	public bool EJPELPJHBEE(Handle BLIPNDKFLPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x30CAE70", Offset = "0x30C9E70", VA = "0x1830CAE70")]
	private T CLBKMDGGMLI(int MMABPPDCBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x30CC620", Offset = "0x30CB620", VA = "0x1830CC620")]
	private void LOKAJEFELOL(int EANCNGLCPPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public class DJCLGKPCLBB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private readonly Stack<T> FGMDHCGBMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private readonly List<T> OBOLBDHFAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly int GAAAECLEFON;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int GEDDAEHIMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x2400020", Offset = "0x23FF020", VA = "0x182400020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int LOOJNKHNEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1BB9220", Offset = "0x1BB8220", VA = "0x181BB9220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2E43D60", Offset = "0x2E42D60", VA = "0x182E43D60")]
	public static global::DJCLGKPCLBB<T> ADHNLKMNKDE(int JAFEKEGLGFD = 0, int GAAAECLEFON = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2E43F20", Offset = "0x2E42F20", VA = "0x182E43F20")]
	public static global::DJCLGKPCLBB<T> ENFCGBJJKLB(int JAFEKEGLGFD = 0, int GAAAECLEFON = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2E44550", Offset = "0x2E43550", VA = "0x182E44550")]
	public DJCLGKPCLBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2E44590", Offset = "0x2E43590", VA = "0x182E44590")]
	public DJCLGKPCLBB(int JAFEKEGLGFD, int GAAAECLEFON = int.MaxValue, bool GLGIGALJOPN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2E443B0", Offset = "0x2E433B0", VA = "0x182E443B0")]
	public T LLHBACCELBH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2E44070", Offset = "0x2E43070", VA = "0x182E44070")]
	public void GCLFHHNKHLO(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2E44140", Offset = "0x2E43140", VA = "0x182E44140")]
	private void IJNPDGLJDMC(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x2E44120", Offset = "0x2E43120", VA = "0x182E44120")]
	private void HLMKCNADGLF(T CCIMHDCKHOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x2E43FF0", Offset = "0x2E42FF0", VA = "0x182E43FF0")]
	[Conditional("DEBUG_BUILD")]
	private void GABGHKLABKP(T JAJBGLDNOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2E444C0", Offset = "0x2E434C0", VA = "0x182E444C0")]
	[Conditional("DEBUG_BUILD")]
	private void NJGHJJENLJI(T JAJBGLDNOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2E43E30", Offset = "0x2E42E30", VA = "0x182E43E30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2E44210", Offset = "0x2E43210", VA = "0x182E44210")]
	private void KBLCFHHPENE(IEnumerable<T> JIECDBDFHOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public class KGOFJDAEOBB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private Dictionary<int, T> AAEIBLIDHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private T IFMDOFCBOGO;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T PBMINIPAMCB
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x66A140", Offset = "0x669140", VA = "0x18066A140", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool BINDBGMEGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x2901200", Offset = "0x2900200", VA = "0x182901200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2901170", Offset = "0x2900170", VA = "0x182901170")]
	public bool DIBDKEEBIJK(T CCIMHDCKHOF, int PCMCGMOPFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x29017D0", Offset = "0x29007D0", VA = "0x1829017D0")]
	public bool NOCLIFBDPIH(int PCMCGMOPFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x29015E0", Offset = "0x29005E0", VA = "0x1829015E0")]
	public T MEFKHIDNNHL(int JBOBKINEJNO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2901830", Offset = "0x2900830", VA = "0x182901830")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2901350", Offset = "0x2900350", VA = "0x182901350")]
	private bool KMMICBEBEBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x29011D0", Offset = "0x29001D0", VA = "0x1829011D0")]
	public bool EPBHELLGDLM(int PCMCGMOPFKB, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x2901890", Offset = "0x2900890", VA = "0x182901890")]
	public KGOFJDAEOBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class PCOPKCLJFKF<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	protected struct FFHLHMAFGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public T FHONEBOCBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public int NCABMENALPB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	protected readonly List<FFHLHMAFGFO> DOACBDBBJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private T ILFLKADEOGJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x2026530", Offset = "0x2025530", VA = "0x182026530")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x2D241C0", Offset = "0x2D231C0", VA = "0x182D241C0")]
	public bool CBBIGPLMGHA(T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x2D243D0", Offset = "0x2D233D0", VA = "0x182D243D0")]
	public void CEMPCIEDPMO(T CCIMHDCKHOF, int PCMCGMOPFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x2D240A0", Offset = "0x2D230A0", VA = "0x182D240A0")]
	public bool ADDEDGCCJIP(T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x2D24710", Offset = "0x2D23710", VA = "0x182D24710")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x2D244E0", Offset = "0x2D234E0", VA = "0x182D244E0")]
	public T FKLNIHMLJNI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x2D24470", Offset = "0x2D23470", VA = "0x182D24470")]
	public T FKEDDPMFMCK()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x2D24550", Offset = "0x2D23550", VA = "0x182D24550")]
	private void GCOABBKGKJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x2D24770", Offset = "0x2D23770", VA = "0x182D24770")]
	public PCOPKCLJFKF()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		[HOEJGCAGKOC(APAJCDGALOH.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x5D2E430", Offset = "0x5D2D430", VA = "0x185D2E430")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x5D2E7C0", Offset = "0x5D2D7C0", VA = "0x185D2E7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x5D2E640", Offset = "0x5D2D640", VA = "0x185D2E640")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x5D2E920", Offset = "0x5D2D920", VA = "0x185D2E920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x5D2E350", Offset = "0x5D2D350", VA = "0x185D2E350")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x5D2E6E0", Offset = "0x5D2D6E0", VA = "0x185D2E6E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x5D2E560", Offset = "0x5D2D560", VA = "0x185D2E560")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D2E300", Offset = "0x5D2D300", VA = "0x185D2E300")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public interface HKJLDGJADAC
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public abstract class ResourcePrefabReference<T> : HKJLDGJADAC where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x26BA5F0", Offset = "0x26B95F0", VA = "0x1826BA5F0", Slot = "4")]
		public virtual T IMIMEKHBPHC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
public class ABAFJCPHOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private readonly Dictionary<byte, JDDONDMMDDL> NGAADEFOFIP;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public JDDONDMMDDL BKNINIHHFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x64BAC0", Offset = "0x64AAC0", VA = "0x18064BAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x66A130", Offset = "0x669130", VA = "0x18066A130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 HPHMFKEIDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x12F0C20", Offset = "0x12EFC20", VA = "0x1812F0C20")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x693CD0", Offset = "0x692CD0", VA = "0x180693CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 LOFPLJJNALM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x12F0C00", Offset = "0x12EFC00", VA = "0x1812F0C00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x12AAF40", Offset = "0x12A9F40", VA = "0x1812AAF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 HHMHNPENPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5D26C70", Offset = "0x5D25C70", VA = "0x185D26C70")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x1C18B10", Offset = "0x1C17B10", VA = "0x181C18B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int AIOHNPLLAOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x64A0E0", Offset = "0x6490E0", VA = "0x18064A0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6B1640", Offset = "0x6B0640", VA = "0x1806B1640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5D27210", Offset = "0x5D26210", VA = "0x185D27210")]
	public ABAFJCPHOEK(Bounds OLOGIODGCBG, Vector2[] JCHIKMBCFHP, int CJOGLKIICBD, byte OFHLFABGMBH, float JIJLIOGDHFM = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5D26B10", Offset = "0x5D25B10", VA = "0x185D26B10")]
	public JDDONDMMDDL APKHPCDFHDB(byte MMABPPDCBIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5D26B70", Offset = "0x5D25B70", VA = "0x185D26B70")]
	public void CFLBPONKELB(Vector3 LPADDFNBONE, float AIIPOKFHHNI, float EBJKIIEKMJA, ref List<byte> ILDDDBFCGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5D26C90", Offset = "0x5D25C90", VA = "0x185D26C90")]
	public void GJOGCEMKHPJ(JDDONDMMDDL.FIEHBPMLEAK IJLFGCNDLIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5D26CB0", Offset = "0x5D25CB0", VA = "0x185D26CB0")]
	private JDDONDMMDDL INLLIJBPACC(byte MMABPPDCBIB, JDDONDMMDDL.JEDPAAHLGHJ ADPKBFJAKAI, JDDONDMMDDL OJKLIAPCMPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5D26E10", Offset = "0x5D25E10", VA = "0x185D26E10")]
	private void PHDMCIIADPK(JDDONDMMDDL OJKLIAPCMPJ, Vector2[] JCHIKMBCFHP, int GGMFCDOKLFN, int LOGOADKLGNK, int LKNEMOFHLGL, int MJPGJFAKDDD, float JIJLIOGDHFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class JDDONDMMDDL
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public enum JEDPAAHLGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public enum FIEHBPMLEAK
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public byte LMIDIPHLOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public Vector3 NJLDLKDEKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public Vector3 ADODPFDEIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public Vector3 DHMFKNAEKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 LIANPIEJOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public JEDPAAHLGHJ JOKECEGIIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public JDDONDMMDDL AOJBGOEDBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public List<JDDONDMMDDL> INNFOLKFHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public bool MCKNFINHCPC;

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CBB0", Offset = "0x5D2BBB0", VA = "0x185D2CBB0")]
	public JDDONDMMDDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CBD0", Offset = "0x5D2BBD0", VA = "0x185D2CBD0")]
	public JDDONDMMDDL(byte DGFBLJMJMFI, JEDPAAHLGHJ ADPKBFJAKAI, JDDONDMMDDL OJKLIAPCMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CAA0", Offset = "0x5D2BAA0", VA = "0x185D2CAA0")]
	public void FDCLLHDIPLE(JDDONDMMDDL FOCEJAMAOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	public void GJOGCEMKHPJ(int DEKJDMHGKDJ, FIEHBPMLEAK IJLFGCNDLIC, int OGGAFBFPFBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C7F0", Offset = "0x5D2B7F0", VA = "0x185D2C7F0")]
	public void CFLBPONKELB(List<byte> ILDDDBFCGNH, Vector3 LPADDFNBONE, float AIIPOKFHHNI, float EBJKIIEKMJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CB60", Offset = "0x5D2BB60", VA = "0x185D2CB60")]
	public bool JFPIHDKPMHN(Vector3 ADMEPHMBKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5D2C7B0", Offset = "0x5D2B7B0", VA = "0x185D2C7B0")]
	public bool CDNAJELOLPK(Vector3 ADMEPHMBKKP, float IOOBDCMPDDM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class ADKBIIBCKNC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private readonly Dictionary<T, object> PPBBILOHLIL;

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x1BAE110", Offset = "0x1BAD110", VA = "0x181BAE110")]
	public bool NNAOEKHBDAO(T DDAANHOLEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x26D8170", Offset = "0x26D7170", VA = "0x1826D8170")]
	public bool NNAOEKHBDAO(T DDAANHOLEKC, object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x26D81B0", Offset = "0x26D71B0", VA = "0x1826D81B0")]
	public bool NNAOEKHBDAO(T DDAANHOLEKC, object FDKCIGPLPAB, out object NKEJKAMPALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x26D80A0", Offset = "0x26D70A0", VA = "0x1826D80A0")]
	public bool KLECBONDMPI(T DDAANHOLEKC, object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x26D8060", Offset = "0x26D7060", VA = "0x1826D8060")]
	public bool BMHPCALHMII(T DDAANHOLEKC, object FDKCIGPLPAB, out object NKEJKAMPALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x26D80E0", Offset = "0x26D70E0", VA = "0x1826D80E0")]
	public bool KLECBONDMPI(T DDAANHOLEKC, object FDKCIGPLPAB, out object NKEJKAMPALK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x2057080", Offset = "0x2056080", VA = "0x182057080")]
	public void EMJEGPIEBFJ(T DDAANHOLEKC, object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x26D7FC0", Offset = "0x26D6FC0", VA = "0x1826D7FC0")]
	public void AIMPPMFGLLJ(T DDAANHOLEKC, object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x26D8210", Offset = "0x26D7210", VA = "0x1826D8210")]
	public ADKBIIBCKNC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		public struct NDLPAGNOBAB<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			private readonly List<Component> PIJDNOPJENO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			private readonly bool IENBHFNOOHF;

			[Cpp2IlInjected.Token(Token = "0x60003DB")]
			[Cpp2IlInjected.Address(RVA = "0x8C53F0", Offset = "0x8C43F0", VA = "0x1808C53F0")]
			public NDLPAGNOBAB(List<Component> PIJDNOPJENO, bool IENBHFNOOHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x2368DB0", Offset = "0x2367DB0", VA = "0x182368DB0")]
			public JNHPCBIAMBL<T> CDEDLLPMOKO()
			{
				return default(JNHPCBIAMBL<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x2368E20", Offset = "0x2367E20", VA = "0x182368E20", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0x2368E20", Offset = "0x2367E20", VA = "0x182368E20", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AC")]
		public struct JNHPCBIAMBL<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			private readonly List<Component> PIJDNOPJENO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly bool IENBHFNOOHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private int MMABPPDCBIB;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T IKECDOHOPGM
			{
				[Cpp2IlInjected.Token(Token = "0x60003E0")]
				[Cpp2IlInjected.Address(RVA = "0x31266E0", Offset = "0x31256E0", VA = "0x1831266E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0x3126670", Offset = "0x3125670", VA = "0x183126670", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0x31266B0", Offset = "0x31256B0", VA = "0x1831266B0")]
			public JNHPCBIAMBL(List<Component> PIJDNOPJENO, bool IENBHFNOOHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x31265B0", Offset = "0x31255B0", VA = "0x1831265B0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0x31265C0", Offset = "0x31255C0", VA = "0x1831265C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x2E2E9E0", Offset = "0x2E2D9E0", VA = "0x182E2E9E0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x5D30670", Offset = "0x5D2F670", VA = "0x185D30670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x5D30630", Offset = "0x5D2F630", VA = "0x185D30630")]
		public ToolHierarchyCache(GameObject NJPGIIMNPBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FF40", Offset = "0x5D2EF40", VA = "0x185D2FF40")]
		private void CDFKCHBFAME(GameObject NJPGIIMNPBL, bool MJJPNLBDKFE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FEB0", Offset = "0x5D2EEB0", VA = "0x185D2FEB0")]
		public static void CDFKCHBFAME(GameObject NJPGIIMNPBL, ref ToolHierarchyCache EHFJHOENLBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5D30520", Offset = "0x5D2F520", VA = "0x185D30520")]
		public void MJOGFHNBAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5D30120", Offset = "0x5D2F120", VA = "0x185D30120")]
		public void GIFLFLFDMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x2E72220", Offset = "0x2E71220", VA = "0x182E72220")]
		public void GANCNDNOMIJ<T>(Action<T> NCHNGIGODJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5D2FDE0", Offset = "0x5D2EDE0", VA = "0x185D2FDE0")]
		public Component AEAHDOHCMMD(Type BCFKLEGAMEO, bool IENBHFNOOHF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x2E721A0", Offset = "0x2E711A0", VA = "0x182E721A0")]
		public T AEAHDOHCMMD<T>(bool IENBHFNOOHF = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x5D30530", Offset = "0x5D2F530", VA = "0x185D30530")]
		public NDLPAGNOBAB<Component> NJONCPEKMCG(Type BCFKLEGAMEO, bool IENBHFNOOHF = false)
		{
			return default(NDLPAGNOBAB<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x2E724B0", Offset = "0x2E714B0", VA = "0x182E724B0")]
		public NDLPAGNOBAB<T> NJONCPEKMCG<T>(bool IENBHFNOOHF = false) where T : class
		{
			return default(NDLPAGNOBAB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x5D301F0", Offset = "0x5D2F1F0", VA = "0x185D301F0")]
		public List<Component> KABCPFDGBHC(Type BCFKLEGAMEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x5D300A0", Offset = "0x5D2F0A0", VA = "0x185D300A0", Slot = "4")]
		public bool Equals(ToolHierarchyCache ODLLFOGPPIE, ToolHierarchyCache GJCOJHOFJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x5D30170", Offset = "0x5D2F170", VA = "0x185D30170", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ODMJCJPGHNI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public class DFEGJOLPJNA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private int JAFEKEGLGFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private int IJOCGHMHMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private List<T> CFFIGFCFHML;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x2400020", Offset = "0x23FF020", VA = "0x182400020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T ABOGINNEAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E0D0", Offset = "0x2E3D0D0", VA = "0x182E3E0D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T MJABMDDEPAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E220", Offset = "0x2E3D220", VA = "0x182E3E220")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T LGDBLOBNKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x2E3DE70", Offset = "0x2E3CE70", VA = "0x182E3DE70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E360", Offset = "0x2E3D360", VA = "0x182E3E360")]
	public DFEGJOLPJNA(int JAFEKEGLGFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DFA0", Offset = "0x2E3CFA0", VA = "0x182E3DFA0")]
	public void CEMPCIEDPMO(T ADHEHALNHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E320", Offset = "0x2E3D320", VA = "0x182E3E320")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E280", Offset = "0x2E3D280", VA = "0x182E3E280")]
	public void OGEFJHJJJMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E080", Offset = "0x2E3D080", VA = "0x182E3E080")]
	public void CILNMHIPBBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DE10", Offset = "0x2E3CE10", VA = "0x182E3DE10")]
	public void ACLLMILDNFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public class DEMBIJHNBMP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private bool MLFGDBNOFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private Action NCHNGIGODJK;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static DEMBIJHNBMP GJPAOOFPOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B500", Offset = "0x5D2A500", VA = "0x185D2B500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool ILOJPONJFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x64E250", Offset = "0x64D250", VA = "0x18064E250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x81A2E0", Offset = "0x8192E0", VA = "0x18081A2E0")]
	public DEMBIJHNBMP(Action NCHNGIGODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B4E0", Offset = "0x5D2A4E0", VA = "0x185D2B4E0")]
	public void ECFFKMLILHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B4E0", Offset = "0x5D2A4E0", VA = "0x185D2B4E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public static class LNFDJHNEPLP
{
	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x663EB0", Offset = "0x662EB0", VA = "0x180663EB0")]
	public static void AOAHADKEPPA(EDJHEDALKPA FGAAFLEJHAO, string MEDAFNDNOGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class GEEHOEJJKPM<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	private struct BDFBJBCFGEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public int NCABMENALPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public T FHONEBOCBPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private readonly Dictionary<object, BDFBJBCFGEF> AAEIBLIDHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private T IFMDOFCBOGO;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T PBMINIPAMCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x66B040", Offset = "0x66A040", VA = "0x18066B040", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x2CF73E0", Offset = "0x2CF63E0", VA = "0x182CF73E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool BINDBGMEGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x3748CC0", Offset = "0x3747CC0", VA = "0x183748CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object LOGEIIFLPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x68C1C0", Offset = "0x68B1C0", VA = "0x18068C1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x3748740", Offset = "0x3747740", VA = "0x183748740")]
	public bool DIBDKEEBIJK(T CCIMHDCKHOF, object FDKCIGPLPAB, int PCMCGMOPFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x374AEB0", Offset = "0x3749EB0", VA = "0x18374AEB0")]
	public bool NOCLIFBDPIH(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x3748C50", Offset = "0x3747C50", VA = "0x183748C50")]
	public bool EPBHELLGDLM(object FDKCIGPLPAB, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x30D0730", Offset = "0x30CF730", VA = "0x1830D0730")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x3EE1410", Offset = "0x3EE0410", VA = "0x183EE1410")]
	private bool KMMICBEBEBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x2901890", Offset = "0x2900890", VA = "0x182901890")]
	public GEEHOEJJKPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public class BAKNAELJILN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private Dictionary<object, float> AAEIBLIDHOP;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float PJACOPGPGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x10C9020", Offset = "0x10C8020", VA = "0x1810C9020")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xF2F350", Offset = "0xF2E350", VA = "0x180F2F350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5D28BA0", Offset = "0x5D27BA0", VA = "0x185D28BA0")]
	public void DIBDKEEBIJK(float CCIMHDCKHOF, object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5D28C10", Offset = "0x5D27C10", VA = "0x185D28C10")]
	public void NOCLIFBDPIH(object FDKCIGPLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5D28A80", Offset = "0x5D27A80", VA = "0x185D28A80")]
	private void BGCEBOKGFAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5D28C80", Offset = "0x5D27C80", VA = "0x185D28C80")]
	public BAKNAELJILN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class JPJBFCEOADG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public readonly string LGPEPLCFKNM;

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x64AF40", Offset = "0x649F40", VA = "0x18064AF40")]
	public JPJBFCEOADG(string HFLMLGDIMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CE00", Offset = "0x5D2BE00", VA = "0x185D2CE00")]
	public JPJBFCEOADG(UnityEngine.Object ANFNOPKGHNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5D2CDB0", Offset = "0x5D2BDB0", VA = "0x185D2CDB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public sealed class EDJHEDALKPA
{
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class BBPHIMJADPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public BBPHIMJADPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x5D28D00", Offset = "0x5D27D00", VA = "0x185D28D00")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private HashSet<object> BLNGIFHEFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private int GGOLFGKEMFA;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> LJBJBLFBEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BD00", Offset = "0x5D2AD00", VA = "0x185D2BD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool BPPCHEPEICL
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x5D2BF90", Offset = "0x5D2AF90", VA = "0x185D2BF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int CAAMIJFBOBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x64BBD0", Offset = "0x64ABD0", VA = "0x18064BBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BE30", Offset = "0x5D2AE30", VA = "0x185D2BE30")]
	public bool CEMPCIEDPMO(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BC60", Offset = "0x5D2AC60", VA = "0x185D2BC60")]
	public bool ADDEDGCCJIP(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BDD0", Offset = "0x5D2ADD0", VA = "0x185D2BDD0")]
	public bool CBBIGPLMGHA(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BF20", Offset = "0x5D2AF20", VA = "0x185D2BF20")]
	public void LOHBLAJMCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5D2BFA0", Offset = "0x5D2AFA0", VA = "0x185D2BFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public EDJHEDALKPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class AKNLHMNEIEJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	private struct FEGHJAEABPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public float ENFOOFFCBIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public T FHONEBOCBPE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private Dictionary<object, FEGHJAEABPP> AAEIBLIDHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private T ELJEFCKGBFA;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T HJHDGILCDMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1192C20", Offset = "0x1191C20", VA = "0x181192C20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x16C7BC0", Offset = "0x16C6BC0", VA = "0x1816C7BC0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object CACGFAIBJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x6606F0", Offset = "0x65F6F0", VA = "0x1806606F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x6E2AE0", Offset = "0x6E1AE0", VA = "0x1806E2AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool BINDBGMEGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x323F070", Offset = "0x323E070", VA = "0x18323F070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x323E920", Offset = "0x323D920", VA = "0x18323E920")]
	public bool DIBDKEEBIJK(T CCIMHDCKHOF, object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x3240710", Offset = "0x323F710", VA = "0x183240710")]
	public bool NOCLIFBDPIH(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x30D0730", Offset = "0x30CF730", VA = "0x1830D0730")]
	public void OJEEPLKEKIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x323EE00", Offset = "0x323DE00", VA = "0x18323EE00")]
	public bool EPBHELLGDLM(object FDKCIGPLPAB, out T CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x3240030", Offset = "0x323F030", VA = "0x183240030")]
	private bool KMMICBEBEBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x3240770", Offset = "0x323F770", VA = "0x183240770")]
	public AKNLHMNEIEJ()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x5D28450", Offset = "0x5D27450", VA = "0x185D28450")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x5D28560", Offset = "0x5D27560", VA = "0x185D28560")]
	public static string NNIAAAJCFNJ(byte[] CDDAIIMDJCN, bool FNAKCEJPGOO)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
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
