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
public class EIKEKNDBDMN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8FB640", Offset = "0x8FAA40", VA = "0x1808FB640")]
	public EIKEKNDBDMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, DJAJPBBFAAD, BIFJEAMDNDE, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77DF40", Offset = "0x77D340", VA = "0x18077DF40", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x762090", VA = "0x180762C90", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x772CA0", VA = "0x1807738A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash FCNILJEDKDH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x830720", Offset = "0x82FB20", VA = "0x180830720")]
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
	[KPFDNIGBADK]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[KPFDNIGBADK]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x646BB70", Offset = "0x646AF70", VA = "0x18646BB70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x646BB30", Offset = "0x646AF30", VA = "0x18646BB30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x646BBB0", Offset = "0x646AFB0", VA = "0x18646BBB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x646BD80", Offset = "0x646B180", VA = "0x18646BD80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x646BCF0", Offset = "0x646B0F0", VA = "0x18646BCF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85BD40", Offset = "0x85B140", VA = "0x18085BD40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F1C80", Offset = "0x9F1080", VA = "0x1809F1C80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x646BAF0", Offset = "0x646AEF0", VA = "0x18646BAF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x646BC60", Offset = "0x646B060", VA = "0x18646BC60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x646B530", Offset = "0x646A930", VA = "0x18646B530")]
	public void CopyBounds(SavedExtents FJLHJLAMLMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x646BA50", Offset = "0x646AE50", VA = "0x18646BA50")]
	public void SetLocalSpaceBounds(Bounds GCNIOKIJCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xB94BB0", Offset = "0xB93FB0", VA = "0x180B94BB0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x646BA40", Offset = "0x646AE40", VA = "0x18646BA40")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x646B620", Offset = "0x646AA20", VA = "0x18646B620")]
	private void GNHPJJNLDOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x646B810", Offset = "0x646AC10", VA = "0x18646B810")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x646AEF0", Offset = "0x646A2F0", VA = "0x18646AEF0")]
	public static void CalculateLocalBoundsFor(GameObject CEPEJEHMODM, out Bounds GCNIOKIJCND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x646B560", Offset = "0x646A960", VA = "0x18646B560")]
	private static void FGLEJGNMNBJ(Bounds CFEKEMJOJGA, Color JJJCLNDDKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x646BA70", Offset = "0x646AE70", VA = "0x18646BA70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x75ED00", Offset = "0x75E100", VA = "0x18075ED00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x129A4A0", Offset = "0x12998A0", VA = "0x18129A4A0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x123B3E0", Offset = "0x123A7E0", VA = "0x18123B3E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "4")]
	public virtual void JLNIMMBFNLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
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
	[EIKEKNDBDMN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3970810", Offset = "0x396FC10", VA = "0x183970810", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x396FF40", Offset = "0x396F340", VA = "0x18396FF40", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3970D50", Offset = "0x3970150", VA = "0x183970D50")]
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
	private sealed class JACMNDODFLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public JACMNDODFLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3F44BF0", Offset = "0x3F43FF0", VA = "0x183F44BF0")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[EIKEKNDBDMN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2539070", Offset = "0x2538470", VA = "0x182539070", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x25390A0", Offset = "0x25384A0", VA = "0x1825390A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2538FC0", Offset = "0x25383C0", VA = "0x182538FC0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey NPBDKCONLNC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2539020", Offset = "0x2538420", VA = "0x182539020", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2538EC0", Offset = "0x25382C0", VA = "0x182538EC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2538A10", Offset = "0x2537E10", VA = "0x182538A10", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2538230", Offset = "0x2537630", VA = "0x182538230", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2537EB0", Offset = "0x25372B0", VA = "0x182537EB0", Slot = "14")]
	protected virtual string MLCFHIBOOAK(TKeyVal JIDMMPPCPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2537DC0", Offset = "0x25371C0", VA = "0x182537DC0", Slot = "4")]
	public bool ContainsKey(TKey NPBDKCONLNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2538DB0", Offset = "0x25381B0", VA = "0x182538DB0", Slot = "5")]
	public bool TryGetValue(TKey NPBDKCONLNC, out TVal FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2537DF0", Offset = "0x25371F0", VA = "0x182537DF0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2537DF0", Offset = "0x25371F0", VA = "0x182537DF0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2538DE0", Offset = "0x25381E0", VA = "0x182538DE0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DLCBAOBICFJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class MOKEOGJAJNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public MOKEOGJAJNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x35FEDD0", Offset = "0x35FE1D0", VA = "0x1835FEDD0")]
		internal bool <GetSamples>b__0(global::MOEMHBGIAPF<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float HGAFPJCLDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float OEPKLCPCOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::MOEMHBGIAPF<float, T>> NPDOGHNAMOB;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int DGJBMOLKOEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3707770", Offset = "0x3706B70", VA = "0x183707770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3707B90", Offset = "0x3706F90", VA = "0x183707B90")]
	public DLCBAOBICFJ(float FNOJMHIMEFE, float BMLCHHHHAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3707870", Offset = "0x3706C70", VA = "0x183707870")]
	public bool HCHFJOBPGDA(float AHNEEFEJHDH, T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3707B30", Offset = "0x3706F30", VA = "0x183707B30")]
	public int HEPLFKNOHID(float AHNEEFEJHDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3707370", Offset = "0x3706770", VA = "0x183707370")]
	public IEnumerable<T> EHGFMBKJBCC(float AHNEEFEJHDH, [Optional] float? JAJBKACFPNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3707000", Offset = "0x3706400", VA = "0x183707000")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37076B0", Offset = "0x3706AB0", VA = "0x1837076B0")]
	private void FHMHNCEFPAH(float AHNEEFEJHDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class AMKBEAOGKHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct EBJKCDAHOJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T EJBPMDLBLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float MILECAFIBEP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float LOMGEGACNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> AIAPJNKMBHJ;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int LNEDPMPIJGF = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private EBJKCDAHOJK[] OGMMNHCCDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int ECOKMPIPPMO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float JCPHMDNHHDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB082B0", Offset = "0xB076B0", VA = "0x180B082B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB082D0", Offset = "0xB076D0", VA = "0x180B082D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3230290", Offset = "0x322F690", VA = "0x183230290")]
	public AMKBEAOGKHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x32302C0", Offset = "0x322F6C0", VA = "0x1832302C0")]
	public AMKBEAOGKHF(int OLGJFEONMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x322F1D0", Offset = "0x322E5D0", VA = "0x18322F1D0")]
	public void BKCAAEBNAMB(float AHNEEFEJHDH, T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x322F080", Offset = "0x322E480", VA = "0x18322F080")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x322F820", Offset = "0x322EC20", VA = "0x18322F820")]
	public bool FGIEMHCPGJB(float HLGGLCGNNLC, float DGIHAKEODBF, out T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x322FD30", Offset = "0x322F130", VA = "0x18322FD30")]
	public bool LNOEDBCLBCN(float HLGGLCGNNLC, float DGIHAKEODBF, out T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x322FED0", Offset = "0x322F2D0", VA = "0x18322FED0")]
	public void NGDGNLDBMHL(float HLGGLCGNNLC, float DGIHAKEODBF, List<T> DGPBECDNOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x322FEA0", Offset = "0x322F2A0", VA = "0x18322FEA0")]
	private int MBMLKJBLPNA(int AAOGCMEDOCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x322F9E0", Offset = "0x322EDE0", VA = "0x18322F9E0")]
	private void LFABNAEBCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FBCBMKNDHLI();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BKMADJDIBNB(T BEOAJHMDOLI, T CEKIIBILJFE, float MOGPOAHNFIM);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T AKKHNKMOPKJ(T FPLJCBGEJAP, float MOGPOAHNFIM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T KBAGFNEMAAB(T BEOAJHMDOLI, T CEKIIBILJFE);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T KHBGAPOLKNH(T BEOAJHMDOLI, T CEKIIBILJFE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GLDJNNCPCCM : global::AMKBEAOGKHF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1D3CD80", Offset = "0x1D3C180", VA = "0x181D3CD80", Slot = "4")]
	protected override Vector3 FBCBMKNDHLI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2243C20", Offset = "0x2243020", VA = "0x182243C20", Slot = "5")]
	protected override Vector3 BKMADJDIBNB(Vector3 BEOAJHMDOLI, Vector3 CEKIIBILJFE, float MOGPOAHNFIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x64662C0", Offset = "0x64656C0", VA = "0x1864662C0", Slot = "6")]
	protected override Vector3 AKKHNKMOPKJ(Vector3 FPLJCBGEJAP, float MOGPOAHNFIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6466320", Offset = "0x6465720", VA = "0x186466320", Slot = "7")]
	protected override Vector3 KBAGFNEMAAB(Vector3 BEOAJHMDOLI, Vector3 CEKIIBILJFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x64663A0", Offset = "0x64657A0", VA = "0x1864663A0", Slot = "8")]
	protected override Vector3 KHBGAPOLKNH(Vector3 BEOAJHMDOLI, Vector3 CEKIIBILJFE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6466410", Offset = "0x6465810", VA = "0x186466410")]
	public GLDJNNCPCCM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BMPCPCLEKGL : global::AMKBEAOGKHF<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x64633B0", Offset = "0x64627B0", VA = "0x1864633B0")]
	public BMPCPCLEKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6463420", Offset = "0x6462820", VA = "0x186463420")]
	public BMPCPCLEKGL(int OLGJFEONMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xAF43C0", Offset = "0xAF37C0", VA = "0x180AF43C0", Slot = "4")]
	protected override float FBCBMKNDHLI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4281C00", Offset = "0x4281000", VA = "0x184281C00", Slot = "5")]
	protected override float BKMADJDIBNB(float BEOAJHMDOLI, float CEKIIBILJFE, float MOGPOAHNFIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5728F90", Offset = "0x5728390", VA = "0x185728F90", Slot = "6")]
	protected override float AKKHNKMOPKJ(float FPLJCBGEJAP, float MOGPOAHNFIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3B52760", Offset = "0x3B51B60", VA = "0x183B52760", Slot = "7")]
	protected override float KBAGFNEMAAB(float BEOAJHMDOLI, float CEKIIBILJFE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x64633A0", Offset = "0x64627A0", VA = "0x1864633A0", Slot = "8")]
	protected override float KHBGAPOLKNH(float BEOAJHMDOLI, float CEKIIBILJFE)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LHFLODNCEJG
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x296CF40", Offset = "0x296C340", VA = "0x18296CF40")]
	public static global::GLBINCFELJG<T1> PELCFOCODBC<T1>(T1 HBDNJDGBGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x296CA40", Offset = "0x296BE40", VA = "0x18296CA40")]
	public static global::MOEMHBGIAPF<T1, T2> PELCFOCODBC<T1, T2>(T1 HBDNJDGBGON, T2 BECCCFCPBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x296CAB0", Offset = "0x296BEB0", VA = "0x18296CAB0")]
	public static global::PLOOCFIOOJG<T1, T2, T3> PELCFOCODBC<T1, T2, T3>(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x296CE20", Offset = "0x296C220", VA = "0x18296CE20")]
	public static global::BIINMEGILDO<T1, T2, T3, T4> PELCFOCODBC<T1, T2, T3, T4>(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH, T4 OABJHJGMJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x296CD80", Offset = "0x296C180", VA = "0x18296CD80")]
	public static global::JNPGDEAJFIG<T1, T2, T3, T4, T5> PELCFOCODBC<T1, T2, T3, T4, T5>(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH, T4 OABJHJGMJHM, T5 IDEOBHIEMJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x296CCD0", Offset = "0x296C0D0", VA = "0x18296CCD0")]
	public static global::BNPHIANNPKA<T1, T2, T3, T4, T5, T6> PELCFOCODBC<T1, T2, T3, T4, T5, T6>(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH, T4 OABJHJGMJHM, T5 IDEOBHIEMJF, T6 KDBDMBCIMMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x296CC10", Offset = "0x296C010", VA = "0x18296CC10")]
	public static global::GGCNBNJGOOL<T1, T2, T3, T4, T5, T6, T7> PELCFOCODBC<T1, T2, T3, T4, T5, T6, T7>(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH, T4 OABJHJGMJHM, T5 IDEOBHIEMJF, T6 KDBDMBCIMMG, T7 IFABNJJJDBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x296CB40", Offset = "0x296BF40", VA = "0x18296CB40")]
	public static global::AANHOLGJECB<T1, T2, T3, T4, T5, T6, T7, T8> PELCFOCODBC<T1, T2, T3, T4, T5, T6, T7, T8>(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH, T4 OABJHJGMJHM, T5 IDEOBHIEMJF, T6 KDBDMBCIMMG, T7 IFABNJJJDBG, T8 JKMCPCBNAKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x28852C0", Offset = "0x28846C0", VA = "0x1828852C0")]
	[IteratorStateMachine(typeof(MLMDGDILAOG))]
	public static IEnumerable<global::MOEMHBGIAPF<T1, T2>> IFJLFHIOJIL<T1, T2>(IEnumerable<T1> KEPOHMNFLGL, IEnumerable<T2> CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2885400", Offset = "0x2884800", VA = "0x182885400")]
	[IteratorStateMachine(typeof(BKMCIFPPOMD))]
	public static IEnumerable<global::PLOOCFIOOJG<T1, T2, T3>> IFJLFHIOJIL<T1, T2, T3>(IEnumerable<T1> KEPOHMNFLGL, IEnumerable<T2> CFEKEMJOJGA, IEnumerable<T3> JJJCLNDDKAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xDD07A0", Offset = "0xDCFBA0", VA = "0x180DD07A0")]
	internal static int BNCHJLMKJLC(int DCDLDOGMAJO, int IEFMIMFIFNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0xDD0770", Offset = "0xDCFB70", VA = "0x180DD0770")]
	internal static int BNCHJLMKJLC(int DCDLDOGMAJO, int IEFMIMFIFNM, int HOACEAIMHBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xDD0750", Offset = "0xDCFB50", VA = "0x180DD0750")]
	internal static int BNCHJLMKJLC(int DCDLDOGMAJO, int IEFMIMFIFNM, int HOACEAIMHBO, int BKPBDFKNMNB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xDD0780", Offset = "0xDCFB80", VA = "0x180DD0780")]
	internal static int BNCHJLMKJLC(int DCDLDOGMAJO, int IEFMIMFIFNM, int HOACEAIMHBO, int BKPBDFKNMNB, int IHNLPOEGOEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6467A10", Offset = "0x6466E10", VA = "0x186467A10")]
	internal static int BNCHJLMKJLC(int DCDLDOGMAJO, int IEFMIMFIFNM, int HOACEAIMHBO, int BKPBDFKNMNB, int IHNLPOEGOEK, int HBHBBHOGBMK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6467A60", Offset = "0x6466E60", VA = "0x186467A60")]
	internal static int BNCHJLMKJLC(int DCDLDOGMAJO, int IEFMIMFIFNM, int HOACEAIMHBO, int BKPBDFKNMNB, int IHNLPOEGOEK, int HBHBBHOGBMK, int BGKDIKAOPIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6467A30", Offset = "0x6466E30", VA = "0x186467A30")]
	internal static int BNCHJLMKJLC(int DCDLDOGMAJO, int IEFMIMFIFNM, int HOACEAIMHBO, int BKPBDFKNMNB, int IHNLPOEGOEK, int HBHBBHOGBMK, int BGKDIKAOPIK, int MFHKCCMKGFH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class GLBINCFELJG<T1> : IComparable<global::GLBINCFELJG<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 LKBMKCBLGGJ;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x280B190", Offset = "0x280A590", VA = "0x18280B190")]
	public GLBINCFELJG(T1 HBDNJDGBGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x33A8B50", Offset = "0x33A7F50", VA = "0x1833A8B50", Slot = "4")]
	public int CompareTo(global::GLBINCFELJG<T1> FJLHJLAMLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x33A8BC0", Offset = "0x33A7FC0", VA = "0x1833A8BC0", Slot = "0")]
	public override bool Equals(object FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8AD780", Offset = "0x8ACB80", VA = "0x1808AD780", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x33A8C60", Offset = "0x33A8060", VA = "0x1833A8C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MOEMHBGIAPF<T1, T2> : IComparable<global::MOEMHBGIAPF<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 LKBMKCBLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 DPGLEPNJBBM;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x33A2C40", Offset = "0x33A2040", VA = "0x1833A2C40")]
	public MOEMHBGIAPF(T1 HBDNJDGBGON, T2 BECCCFCPBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x35F8A50", Offset = "0x35F7E50", VA = "0x1835F8A50", Slot = "4")]
	public int CompareTo(global::MOEMHBGIAPF<T1, T2> FJLHJLAMLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x35F91F0", Offset = "0x35F85F0", VA = "0x1835F91F0", Slot = "0")]
	public override bool Equals(object FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x35F9A30", Offset = "0x35F8E30", VA = "0x1835F9A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x35F9E90", Offset = "0x35F9290", VA = "0x1835F9E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PLOOCFIOOJG<T1, T2, T3> : IComparable<global::PLOOCFIOOJG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 LKBMKCBLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 DPGLEPNJBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 JHOHBELBPDF;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3D706C0", Offset = "0x3D6FAC0", VA = "0x183D706C0")]
	public PLOOCFIOOJG(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3D6FEB0", Offset = "0x3D6F2B0", VA = "0x183D6FEB0", Slot = "4")]
	public int CompareTo(global::PLOOCFIOOJG<T1, T2, T3> FJLHJLAMLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3D701A0", Offset = "0x3D6F5A0", VA = "0x183D701A0", Slot = "0")]
	public override bool Equals(object FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3D703A0", Offset = "0x3D6F7A0", VA = "0x183D703A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3D70400", Offset = "0x3D6F800", VA = "0x183D70400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BIINMEGILDO<T1, T2, T3, T4> : IComparable<global::BIINMEGILDO<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 LKBMKCBLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 DPGLEPNJBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 JHOHBELBPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 LJPKEAMLNBN;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x2C127E0", Offset = "0x2C11BE0", VA = "0x182C127E0")]
	public BIINMEGILDO(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH, T4 OABJHJGMJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x31D5AF0", Offset = "0x31D4EF0", VA = "0x1831D5AF0", Slot = "4")]
	public int CompareTo(global::BIINMEGILDO<T1, T2, T3, T4> FJLHJLAMLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x31D5C30", Offset = "0x31D5030", VA = "0x1831D5C30", Slot = "0")]
	public override bool Equals(object FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x31D5D50", Offset = "0x31D5150", VA = "0x1831D5D50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x31D5E10", Offset = "0x31D5210", VA = "0x1831D5E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JNPGDEAJFIG<T1, T2, T3, T4, T5> : IComparable<global::JNPGDEAJFIG<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 LKBMKCBLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 DPGLEPNJBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 JHOHBELBPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 LJPKEAMLNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 LFLPLFDGHFD;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x36FC540", Offset = "0x36FB940", VA = "0x1836FC540")]
	public JNPGDEAJFIG(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH, T4 OABJHJGMJHM, T5 IDEOBHIEMJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x37AC6E0", Offset = "0x37ABAE0", VA = "0x1837AC6E0", Slot = "4")]
	public int CompareTo(global::JNPGDEAJFIG<T1, T2, T3, T4, T5> FJLHJLAMLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x37AC860", Offset = "0x37ABC60", VA = "0x1837AC860", Slot = "0")]
	public override bool Equals(object FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x37AC9A0", Offset = "0x37ABDA0", VA = "0x1837AC9A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x37ACAA0", Offset = "0x37ABEA0", VA = "0x1837ACAA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BNPHIANNPKA<T1, T2, T3, T4, T5, T6> : IComparable<global::BNPHIANNPKA<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 LKBMKCBLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 DPGLEPNJBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 JHOHBELBPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 LJPKEAMLNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 LFLPLFDGHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 LCHHBGDPFMB;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x31E77C0", Offset = "0x31E6BC0", VA = "0x1831E77C0")]
	public BNPHIANNPKA(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH, T4 OABJHJGMJHM, T5 IDEOBHIEMJF, T6 KDBDMBCIMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x31E7200", Offset = "0x31E6600", VA = "0x1831E7200", Slot = "4")]
	public int CompareTo(global::BNPHIANNPKA<T1, T2, T3, T4, T5, T6> FJLHJLAMLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x31E73C0", Offset = "0x31E67C0", VA = "0x1831E73C0", Slot = "0")]
	public override bool Equals(object FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x31E7530", Offset = "0x31E6930", VA = "0x1831E7530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x31E7650", Offset = "0x31E6A50", VA = "0x1831E7650", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class GGCNBNJGOOL<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::GGCNBNJGOOL<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 LKBMKCBLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 DPGLEPNJBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 JHOHBELBPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 LJPKEAMLNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 LFLPLFDGHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 LCHHBGDPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 HMNEJBJACHN;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x339A5A0", Offset = "0x33999A0", VA = "0x18339A5A0")]
	public GGCNBNJGOOL(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH, T4 OABJHJGMJHM, T5 IDEOBHIEMJF, T6 KDBDMBCIMMG, T7 IFABNJJJDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3399F20", Offset = "0x3399320", VA = "0x183399F20", Slot = "4")]
	public int CompareTo(global::GGCNBNJGOOL<T1, T2, T3, T4, T5, T6, T7> FJLHJLAMLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x339A120", Offset = "0x3399520", VA = "0x18339A120", Slot = "0")]
	public override bool Equals(object FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x339A2C0", Offset = "0x33996C0", VA = "0x18339A2C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x339A410", Offset = "0x3399810", VA = "0x18339A410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AANHOLGJECB<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::AANHOLGJECB<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 LKBMKCBLGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 DPGLEPNJBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 JHOHBELBPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 LJPKEAMLNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 LFLPLFDGHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 LCHHBGDPFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 HMNEJBJACHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 PFPGNCHOPCE;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x493E1C0", Offset = "0x493D5C0", VA = "0x18493E1C0")]
	public AANHOLGJECB(T1 HBDNJDGBGON, T2 BECCCFCPBDH, T3 NKGMOOIDLDH, T4 OABJHJGMJHM, T5 IDEOBHIEMJF, T6 KDBDMBCIMMG, T7 IFABNJJJDBG, T8 JKMCPCBNAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x493DA90", Offset = "0x493CE90", VA = "0x18493DA90", Slot = "4")]
	public int CompareTo(global::AANHOLGJECB<T1, T2, T3, T4, T5, T6, T7, T8> FJLHJLAMLMA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x493DCE0", Offset = "0x493D0E0", VA = "0x18493DCE0", Slot = "0")]
	public override bool Equals(object FJLHJLAMLMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x493DEA0", Offset = "0x493D2A0", VA = "0x18493DEA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x493E010", Offset = "0x493D410", VA = "0x18493E010", Slot = "3")]
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
	public T EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xCF6420", Offset = "0xCF5820", VA = "0x180CF6420")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xCF64D0", Offset = "0xCF58D0", VA = "0x180CF64D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float MBHFIMLGGOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8D3FE0", Offset = "0x8D33E0", VA = "0x1808D3FE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4626450", Offset = "0x4625850", VA = "0x184626450")]
	public T EFIOHBCGABE(float MOGPOAHNFIM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4626190", Offset = "0x4625590", VA = "0x184626190")]
	public T DHKOHLPMPEA(float MOGPOAHNFIM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BKMADJDIBNB(T BEOAJHMDOLI, T CEKIIBILJFE, float MOGPOAHNFIM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4281C00", Offset = "0x4281000", VA = "0x184281C00", Slot = "4")]
	protected override float BKMADJDIBNB(float BEOAJHMDOLI, float CEKIIBILJFE, float MOGPOAHNFIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6464FA0", Offset = "0x64643A0", VA = "0x186464FA0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x2243C20", Offset = "0x2243020", VA = "0x182243C20", Slot = "4")]
	protected override Vector3 BKMADJDIBNB(Vector3 BEOAJHMDOLI, Vector3 CEKIIBILJFE, float MOGPOAHNFIM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x646CC90", Offset = "0x646C090", VA = "0x18646CC90")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x64635F0", Offset = "0x64629F0", VA = "0x1864635F0", Slot = "4")]
	protected override Color BKMADJDIBNB(Color BEOAJHMDOLI, Color CEKIIBILJFE, float MOGPOAHNFIM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6463640", Offset = "0x6462A40", VA = "0x186463640")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PCIFOIAOLGE : global::MHPONCPIFDE<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6469620", Offset = "0x6468A20", VA = "0x186469620")]
	public PCIFOIAOLGE(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6469670", Offset = "0x6468A70", VA = "0x186469670")]
	public PCIFOIAOLGE(JCEIGACJMHH[] PIKKADCAMCB, bool HEALNPHLFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x64695B0", Offset = "0x64689B0", VA = "0x1864695B0", Slot = "6")]
	protected override uint IKGBPIBLEIK(uint FCNILJEDKDH, string FPLJCBGEJAP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OFFPNIGHOMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public OFFPNIGHOMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct OAJMKIHBIGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class IJPFHILBAHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public IJPFHILBAHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x2809600", Offset = "0x2808A00", VA = "0x182809600")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IKOLFEDKJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int BHNCNEGIGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int GANLOCEJKOI;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xB8BF10", Offset = "0xB8B310", VA = "0x180B8BF10")]
	private OAJMKIHBIGF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> LBDOPOGGEHL, int ABFACJJBHCD, int OOOKBBDPMIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x2C0F0F0", Offset = "0x2C0E4F0", VA = "0x182C0F0F0")]
	public static global::OAJMKIHBIGF<T> GEGCLDEHDAN()
	{
		return default(global::OAJMKIHBIGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2C0E290", Offset = "0x2C0D690", VA = "0x182C0E290")]
	public (int, int, Task<T>) AKAEMILJONP(int HBEOHAENGAI, [Optional] CancellationToken MJMCKAGGCOI, double KIGCMENMIJC = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x2C0F520", Offset = "0x2C0E920", VA = "0x182C0F520")]
	public void HCJMFHDOPDM(int HBEOHAENGAI, int OOOKBBDPMIM, in T CGKNIAMFPAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class NFADFJFPOLB
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6468AB0", Offset = "0x6467EB0", VA = "0x186468AB0")]
	public static global::OAJMKIHBIGF<HOGMLAALAEJ> GEGCLDEHDAN()
	{
		return default(global::OAJMKIHBIGF<HOGMLAALAEJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6468B00", Offset = "0x6467F00", VA = "0x186468B00")]
	public static void HCJMFHDOPDM(this in global::OAJMKIHBIGF<HOGMLAALAEJ> COBPFFJEBON, int HBEOHAENGAI, int OOOKBBDPMIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class ANJLMJKGMBM<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> JCKEFJOHJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> LPDAAEMAJOJ;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x27EABD0", Offset = "0x27E9FD0", VA = "0x1827EABD0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool HINCDHEAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> JIEPJEOPLPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3232500", Offset = "0x3231900", VA = "0x183232500", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> NKKHOMIHCKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2804E80", Offset = "0x2804280", VA = "0x182804E80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x32324C0", Offset = "0x32318C0", VA = "0x1832324C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3232530", Offset = "0x3231930", VA = "0x183232530", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3231860", Offset = "0x3230C60", VA = "0x183231860")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3231FC0", Offset = "0x32313C0", VA = "0x183231FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3231A40", Offset = "0x3230E40", VA = "0x183231A40", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3232310", Offset = "0x3231710", VA = "0x183232310", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3231640", Offset = "0x3230A40", VA = "0x183231640", Slot = "9")]
	public void Add(TKey NPBDKCONLNC, TVal FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3231710", Offset = "0x3230B10", VA = "0x183231710", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3231AA0", Offset = "0x3230EA0", VA = "0x183231AA0", Slot = "8")]
	public bool ContainsKey(TKey NPBDKCONLNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3231AD0", Offset = "0x3230ED0", VA = "0x183231AD0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3232230", Offset = "0x3231630", VA = "0x183232230", Slot = "10")]
	public bool Remove(TKey NPBDKCONLNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3232260", Offset = "0x3231660", VA = "0x183232260", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x31E63F0", Offset = "0x31E57F0", VA = "0x1831E63F0", Slot = "11")]
	public bool TryGetValue(TKey NPBDKCONLNC, out TVal FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3231C30", Offset = "0x3231030", VA = "0x183231C30", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3231B30", Offset = "0x3230F30", VA = "0x183231B30", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] OGMMNHCCDJE, int HCDIEBFNKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3231910", Offset = "0x3230D10", VA = "0x183231910")]
	public void BKCAAEBNAMB(TVal MMHJJFKDNDC, TKey NPBDKCONLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x32318D0", Offset = "0x3230CD0", VA = "0x1832318D0")]
	public void BKCAAEBNAMB(KeyValuePair<TVal, TKey> GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3231F80", Offset = "0x3231380", VA = "0x183231F80")]
	public bool OEEOBJEMHMA(TVal NPBDKCONLNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x32315A0", Offset = "0x32309A0", VA = "0x1832315A0")]
	public bool AGHBGCOAOGM(KeyValuePair<TVal, TKey> GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3231BC0", Offset = "0x3230FC0", VA = "0x183231BC0")]
	public bool GAMANBAONBG(TVal NPBDKCONLNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3231BC0", Offset = "0x3230FC0", VA = "0x183231BC0")]
	public bool GAMANBAONBG(KeyValuePair<TVal, TKey> GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3231EE0", Offset = "0x32312E0", VA = "0x183231EE0")]
	public bool MPHIBFICBKB(TVal NPBDKCONLNC, out TKey FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x3231750", Offset = "0x3230B50", VA = "0x183231750")]
	public IEnumerator<KeyValuePair<TVal, TKey>> BDFADMBJFKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3231DC0", Offset = "0x32311C0", VA = "0x183231DC0")]
	private void IIALFLOHBCN(TKey NPBDKCONLNC, TVal MMHJJFKDNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3232080", Offset = "0x3231480", VA = "0x183232080")]
	private void PHJKDBEKMBK(TKey NPBDKCONLNC, TVal MMHJJFKDNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3231270", Offset = "0x3230670", VA = "0x183231270")]
	private bool ABBPOIMPIKP(TKey NPBDKCONLNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x3231340", Offset = "0x3230740", VA = "0x183231340")]
	private bool ABBPOIMPIKP(TVal MMHJJFKDNDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x32323B0", Offset = "0x32317B0", VA = "0x1832323B0")]
	public ANJLMJKGMBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class NEGLNLAFEBK<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::NEGLNLAFEBK<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x3B826C0", Offset = "0x3B81AC0", VA = "0x183B826C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3AE7300", Offset = "0x3AE6700", VA = "0x183AE7300")]
		public Enumerator(global::NEGLNLAFEBK<T> DGPBECDNOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3B7EBD0", Offset = "0x3B7DFD0", VA = "0x183B7EBD0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B809E0", Offset = "0x3B7FDE0", VA = "0x183B809E0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3B80570", Offset = "0x3B7F970", VA = "0x183B80570")]
		private void PAGNCGBLLIB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] BHDEFDFAKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int FAOJDGPICDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int PMLKLNHBLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int IIMAMIPIKFH;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A2F0", Offset = "0x3F996F0", VA = "0x183F9A2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F99EB0", Offset = "0x3F992B0", VA = "0x183F99EB0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3F9BA80", Offset = "0x3F9AE80", VA = "0x183F9BA80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3F9BD10", Offset = "0x3F9B110", VA = "0x183F9BD10")]
	public NEGLNLAFEBK(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3F9A000", Offset = "0x3F99400", VA = "0x183F9A000")]
	public void BKCAAEBNAMB(T MOGPOAHNFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3F9B330", Offset = "0x3F9A730", VA = "0x183F9B330")]
	public void MNIAAMBKOLF(IEnumerable<T> MCFECKFIGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3F99FE0", Offset = "0x3F993E0", VA = "0x183F99FE0")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x3F99DD0", Offset = "0x3F991D0", VA = "0x183F99DD0")]
	public void BDDOBJLLGDB(int NDNADCNCIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x3F9BB00", Offset = "0x3F9AF00", VA = "0x183F9BB00")]
	public void PMAKBIPCECL(int NDNADCNCIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x3F9ABC0", Offset = "0x3F99FC0", VA = "0x183F9ABC0")]
	public void MDHAAFGJDJE(T[] OGMMNHCCDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F9A370", Offset = "0x3F99770", VA = "0x183F9A370")]
	public Enumerator IINGNKPPFJF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x3F9BB90", Offset = "0x3F9AF90", VA = "0x183F9BB90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F9BB90", Offset = "0x3F9AF90", VA = "0x183F9BB90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3F9A6E0", Offset = "0x3F99AE0", VA = "0x183F9A6E0")]
	private int LDBNLEPIGMK(int GABJOMFFJAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3F9A3E0", Offset = "0x3F997E0", VA = "0x183F9A3E0")]
	private int JJKHLEBIEMD(int GABJOMFFJAI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class IPJIOLEBECM<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> MDEPENANODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> FAAKIAOFDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> JOLFKOMKBCI;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> GHOGMHLGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x762090", VA = "0x180762C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool HINCDHEAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8A81C0", Offset = "0x8A75C0", VA = "0x1808A81C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8A8250", Offset = "0x8A7650", VA = "0x1808A8250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x33C9090", Offset = "0x33C8490", VA = "0x1833C9090", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x33C9130", Offset = "0x33C8530", VA = "0x1833C9130", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x33C9030", Offset = "0x33C8430", VA = "0x1833C9030", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x33C8FA0", Offset = "0x33C83A0", VA = "0x1833C8FA0")]
	public IPJIOLEBECM(Func<Internal, External> MDEPENANODK, Func<External, Internal> FAAKIAOFDFO, bool PDFHGGAOKAG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x33C8D10", Offset = "0x33C8110", VA = "0x1833C8D10", Slot = "6")]
	public int IndexOf(External GABBPODJMBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x33C8990", Offset = "0x33C7D90", VA = "0x1833C8990", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x33C89F0", Offset = "0x33C7DF0", VA = "0x1833C89F0", Slot = "13")]
	public bool Contains(External GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x33C8A80", Offset = "0x33C7E80", VA = "0x1833C8A80", Slot = "14")]
	public void CopyTo(External[] OGMMNHCCDJE, int HCDIEBFNKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x33C88A0", Offset = "0x33C7CA0", VA = "0x1833C88A0", Slot = "11")]
	public void Add(External GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x33C8E00", Offset = "0x33C8200", VA = "0x1833C8E00", Slot = "7")]
	public void Insert(int GABJOMFFJAI, External GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x33C8F10", Offset = "0x33C8310", VA = "0x1833C8F10", Slot = "15")]
	public bool Remove(External GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x33C8EA0", Offset = "0x33C82A0", VA = "0x1833C8EA0", Slot = "8")]
	public void RemoveAt(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x33C8CA0", Offset = "0x33C80A0", VA = "0x1833C8CA0", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x31F1CD0", Offset = "0x31F10D0", VA = "0x1831F1CD0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class MIFJOEBCGPH<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> MDEPENANODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> JOLFKOMKBCI;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> GHOGMHLGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x77DF40", Offset = "0x77D340", VA = "0x18077DF40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool HINCDHEAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x380F610", Offset = "0x380EA10", VA = "0x18380F610", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x380F5B0", Offset = "0x380E9B0", VA = "0x18380F5B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x280B190", Offset = "0x280A590", VA = "0x18280B190")]
	public MIFJOEBCGPH(Func<Internal, External> MDEPENANODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x380F560", Offset = "0x380E960", VA = "0x18380F560")]
	public MIFJOEBCGPH(IReadOnlyList<Internal> JOLFKOMKBCI, Func<Internal, External> MDEPENANODK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x380F340", Offset = "0x380E740", VA = "0x18380F340")]
	public void MDHAAFGJDJE(External[] OGMMNHCCDJE, int HCDIEBFNKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x380F2D0", Offset = "0x380E6D0", VA = "0x18380F2D0", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x2CCD340", Offset = "0x2CCC740", VA = "0x182CCD340", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class HFNCDJAPHBK<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> JOLFKOMKBCI;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> GHOGMHLGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool HINCDHEAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x39CA530", Offset = "0x39C9930", VA = "0x1839CA530", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x39CA4D0", Offset = "0x39C98D0", VA = "0x1839CA4D0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x280B190", Offset = "0x280A590", VA = "0x18280B190")]
	public HFNCDJAPHBK(IReadOnlyList<Internal> JOLFKOMKBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x39CA190", Offset = "0x39C9590", VA = "0x1839CA190")]
	public bool AGHBGCOAOGM(External GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x39CA2A0", Offset = "0x39C96A0", VA = "0x1839CA2A0")]
	public void MDHAAFGJDJE(External[] OGMMNHCCDJE, int HCDIEBFNKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x39CA230", Offset = "0x39C9630", VA = "0x1839CA230", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x31F1CD0", Offset = "0x31F10D0", VA = "0x1831F1CD0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class JNJADPDOLBI
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void LPHEPEKDIII(object[] DMNIOKOCJFF);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	protected JNJADPDOLBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class DEJCILHAPPD<T> : JNJADPDOLBI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct ABPCLLBJKEP
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum PKNNOCLAJDD
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
		public PKNNOCLAJDD BKGBGEHNCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T EFFJGLADCMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int OKLAGKIECJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool FLKJPOEMFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool DHOHFAPODIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> CPELLBEOEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<ABPCLLBJKEP> EGGNALGNHJP;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool KMAPKIMAIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x35114E0", Offset = "0x35108E0", VA = "0x1835114E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3511520", Offset = "0x3510920", VA = "0x183511520")]
	protected DEJCILHAPPD(bool DHOHFAPODIM, bool FLKJPOEMFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x35113A0", Offset = "0x35107A0", VA = "0x1835113A0")]
	protected bool GLOPDLODFFO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3511420", Offset = "0x3510820", VA = "0x183511420")]
	protected void LBDFOMNFONF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x3510F50", Offset = "0x3510350", VA = "0x183510F50")]
	protected void BIOKEHJKHIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3459870", Offset = "0x3458C70", VA = "0x183459870")]
	private static void JJIIFKNKFOI<U>(ref List<U> JOLFKOMKBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3511100", Offset = "0x3510500", VA = "0x183511100", Slot = "5")]
	public void BKCAAEBNAMB(T EFFJGLADCMH, bool BFGEODOBABP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x3511260", Offset = "0x3510660", VA = "0x183511260", Slot = "6")]
	public void GAMANBAONBG(T EFFJGLADCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x3510E40", Offset = "0x3510240", VA = "0x183510E40")]
	public void BIEFCABEIDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface LOEEHNPAAPI
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKCAAEBNAMB(Action EFFJGLADCMH, bool BFGEODOBABP = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAMANBAONBG(Action EFFJGLADCMH);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class EKMBIMLBDEI : global::DEJCILHAPPD<Action>, LOEEHNPAAPI
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6464B60", Offset = "0x6463F60", VA = "0x186464B60")]
	public EKMBIMLBDEI(bool DHOHFAPODIM = false, bool FLKJPOEMFJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6464950", Offset = "0x6463D50", VA = "0x186464950")]
	public void PECAEBJKGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6464880", Offset = "0x6463C80", VA = "0x186464880", Slot = "4")]
	public override void LPHEPEKDIII(object[] DMNIOKOCJFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6464820", Offset = "0x6463C20", VA = "0x186464820")]
	public static EKMBIMLBDEI FONHFAPECDI(EKMBIMLBDEI DBLCMMGAOKK, Action EFFJGLADCMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x64648F0", Offset = "0x6463CF0", VA = "0x1864648F0")]
	public static EKMBIMLBDEI NPIIEEFEKIN(EKMBIMLBDEI DBLCMMGAOKK, Action EFFJGLADCMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface DHGMGFLNADN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKCAAEBNAMB(Action<T> EFFJGLADCMH, bool BFGEODOBABP = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAMANBAONBG(Action<T> EFFJGLADCMH);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class EGMEAJPGDMB<T> : global::DEJCILHAPPD<Action<T>>, global::DHGMGFLNADN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2803070", Offset = "0x2802470", VA = "0x182803070")]
	public EGMEAJPGDMB(bool DHOHFAPODIM = false, bool FLKJPOEMFJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x3B2F9F0", Offset = "0x3B2EDF0", VA = "0x183B2F9F0")]
	public void PECAEBJKGCF(T MOGPOAHNFIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x3B2D530", Offset = "0x3B2C930", VA = "0x183B2D530", Slot = "4")]
	public override void LPHEPEKDIII(object[] DMNIOKOCJFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x3B2C840", Offset = "0x3B2BC40", VA = "0x183B2C840")]
	public static global::EGMEAJPGDMB<T> FONHFAPECDI(global::EGMEAJPGDMB<T> DBLCMMGAOKK, Action<T> EFFJGLADCMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x3B2E6D0", Offset = "0x3B2DAD0", VA = "0x183B2E6D0")]
	public static global::EGMEAJPGDMB<T> NPIIEEFEKIN(global::EGMEAJPGDMB<T> DBLCMMGAOKK, Action<T> EFFJGLADCMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface JGJCNMJLKBL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKCAAEBNAMB(Action<T, U> EFFJGLADCMH, bool BFGEODOBABP = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAMANBAONBG(Action<T, U> EFFJGLADCMH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class JOCEIKBAJFB<T, U> : global::DEJCILHAPPD<Action<T, U>>, global::JGJCNMJLKBL<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2803070", Offset = "0x2802470", VA = "0x182803070")]
	public JOCEIKBAJFB(bool DHOHFAPODIM = false, bool FLKJPOEMFJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x37B13B0", Offset = "0x37B07B0", VA = "0x1837B13B0")]
	public void PECAEBJKGCF(T MOGPOAHNFIM, U OHNCDLFJBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x37AE4B0", Offset = "0x37AD8B0", VA = "0x1837AE4B0", Slot = "4")]
	public override void LPHEPEKDIII(object[] DMNIOKOCJFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x37ACBF0", Offset = "0x37ABFF0", VA = "0x1837ACBF0")]
	public static global::JOCEIKBAJFB<T, U> FONHFAPECDI(global::JOCEIKBAJFB<T, U> DBLCMMGAOKK, Action<T, U> EFFJGLADCMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x37AFC60", Offset = "0x37AF060", VA = "0x1837AFC60")]
	public static global::JOCEIKBAJFB<T, U> NPIIEEFEKIN(global::JOCEIKBAJFB<T, U> DBLCMMGAOKK, Action<T, U> EFFJGLADCMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface MBHBPIGCNBO<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKCAAEBNAMB(Action<T, U, V> EFFJGLADCMH, bool BFGEODOBABP = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAMANBAONBG(Action<T, U, V> EFFJGLADCMH);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class HPEJKBNJDLG<T, U, V> : global::DEJCILHAPPD<Action<T, U, V>>, global::MBHBPIGCNBO<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2803070", Offset = "0x2802470", VA = "0x182803070")]
	public HPEJKBNJDLG(bool DHOHFAPODIM = false, bool FLKJPOEMFJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x41AC770", Offset = "0x41ABB70", VA = "0x1841AC770")]
	public void PECAEBJKGCF(T MOGPOAHNFIM, U OHNCDLFJBCH, V OLMDMLKDJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x41A93B0", Offset = "0x41A87B0", VA = "0x1841A93B0", Slot = "4")]
	public override void LPHEPEKDIII(object[] DMNIOKOCJFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x41A8CC0", Offset = "0x41A80C0", VA = "0x1841A8CC0")]
	public static global::HPEJKBNJDLG<T, U, V> FONHFAPECDI(global::HPEJKBNJDLG<T, U, V> DBLCMMGAOKK, Action<T, U, V> EFFJGLADCMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x41AAB10", Offset = "0x41A9F10", VA = "0x1841AAB10")]
	public static global::HPEJKBNJDLG<T, U, V> NPIIEEFEKIN(global::HPEJKBNJDLG<T, U, V> DBLCMMGAOKK, Action<T, U, V> EFFJGLADCMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FAHBGLDBLBC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKCAAEBNAMB(Action<T, U, V, W> EFFJGLADCMH, bool BFGEODOBABP = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAMANBAONBG(Action<T, U, V, W> EFFJGLADCMH);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class IGIJJDOHPOF<T, U, V, W> : global::DEJCILHAPPD<Action<T, U, V, W>>, global::FAHBGLDBLBC<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2803070", Offset = "0x2802470", VA = "0x182803070")]
	public IGIJJDOHPOF(bool DHOHFAPODIM = false, bool FLKJPOEMFJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x2802B90", Offset = "0x2801F90", VA = "0x182802B90")]
	public void PECAEBJKGCF(T MOGPOAHNFIM, U OHNCDLFJBCH, V OLMDMLKDJGG, W MIIKBFLPBBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x2801800", Offset = "0x2800C00", VA = "0x182801800", Slot = "4")]
	public override void LPHEPEKDIII(object[] DMNIOKOCJFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x28005C0", Offset = "0x27FF9C0", VA = "0x1828005C0")]
	public static global::IGIJJDOHPOF<T, U, V, W> FONHFAPECDI(global::IGIJJDOHPOF<T, U, V, W> DBLCMMGAOKK, Action<T, U, V, W> EFFJGLADCMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2801AD0", Offset = "0x2800ED0", VA = "0x182801AD0")]
	public static global::IGIJJDOHPOF<T, U, V, W> NPIIEEFEKIN(global::IGIJJDOHPOF<T, U, V, W> DBLCMMGAOKK, Action<T, U, V, W> EFFJGLADCMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface JGNGCIFLOLE<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKCAAEBNAMB(Action<T, U, V, W, X> EFFJGLADCMH, bool BFGEODOBABP = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAMANBAONBG(Action<T, U, V, W, X> EFFJGLADCMH);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class AGIBCNALHKL<T, U, V, W, X> : global::DEJCILHAPPD<Action<T, U, V, W, X>>, global::JGNGCIFLOLE<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2803070", Offset = "0x2802470", VA = "0x182803070")]
	public AGIBCNALHKL(bool DHOHFAPODIM = false, bool FLKJPOEMFJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3222180", Offset = "0x3221580", VA = "0x183222180")]
	public void PECAEBJKGCF(T MOGPOAHNFIM, U OHNCDLFJBCH, V OLMDMLKDJGG, W MIIKBFLPBBF, X IMDGNLLHHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3221DF0", Offset = "0x32211F0", VA = "0x183221DF0", Slot = "4")]
	public override void LPHEPEKDIII(object[] DMNIOKOCJFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3221A30", Offset = "0x3220E30", VA = "0x183221A30")]
	public static global::AGIBCNALHKL<T, U, V, W, X> FONHFAPECDI(global::AGIBCNALHKL<T, U, V, W, X> DBLCMMGAOKK, Action<T, U, V, W, X> EFFJGLADCMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x32220E0", Offset = "0x32214E0", VA = "0x1832220E0")]
	public static global::AGIBCNALHKL<T, U, V, W, X> NPIIEEFEKIN(global::AGIBCNALHKL<T, U, V, W, X> DBLCMMGAOKK, Action<T, U, V, W, X> EFFJGLADCMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface BMJJJHHNBON<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKCAAEBNAMB(Action<T, U, V, W, X, Y> EFFJGLADCMH, bool BFGEODOBABP = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAMANBAONBG(Action<T, U, V, W, X, Y> EFFJGLADCMH);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class DFIGDKELLFF<T, U, V, W, X, Y> : global::DEJCILHAPPD<Action<T, U, V, W, X, Y>>, global::BMJJJHHNBON<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2803070", Offset = "0x2802470", VA = "0x182803070")]
	public DFIGDKELLFF(bool DHOHFAPODIM = false, bool FLKJPOEMFJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x351FB50", Offset = "0x351EF50", VA = "0x18351FB50")]
	public void PECAEBJKGCF(T MOGPOAHNFIM, U OHNCDLFJBCH, V OLMDMLKDJGG, W MIIKBFLPBBF, X IMDGNLLHHDC, Y NJNDPGIDOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x351F0B0", Offset = "0x351E4B0", VA = "0x18351F0B0", Slot = "4")]
	public override void LPHEPEKDIII(object[] DMNIOKOCJFF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x351F010", Offset = "0x351E410", VA = "0x18351F010")]
	public static global::DFIGDKELLFF<T, U, V, W, X, Y> FONHFAPECDI(global::DFIGDKELLFF<T, U, V, W, X, Y> DBLCMMGAOKK, Action<T, U, V, W, X, Y> EFFJGLADCMH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x351FAB0", Offset = "0x351EEB0", VA = "0x18351FAB0")]
	public static global::DFIGDKELLFF<T, U, V, W, X, Y> NPIIEEFEKIN(global::DFIGDKELLFF<T, U, V, W, X, Y> DBLCMMGAOKK, Action<T, U, V, W, X, Y> EFFJGLADCMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class PKNINEPKILO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct IOILGACIPBC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::PKNINEPKILO<T> IFHGNBDNANG;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T EJBPMDLBLGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x33C8310", Offset = "0x33C7710", VA = "0x1833C8310")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x33C8330", Offset = "0x33C7730", VA = "0x1833C8330", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7809C0", Offset = "0x77FDC0", VA = "0x1807809C0")]
		public IOILGACIPBC(global::PKNINEPKILO<T> IFHGNBDNANG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct OJCDGBOMJPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<IOILGACIPBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::PKNINEPKILO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x2CC77E0", Offset = "0x2CC6BE0", VA = "0x182CC77E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FCF0", Offset = "0x2A3F0F0", VA = "0x182A3FCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct CIGNCCONEIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<IOILGACIPBC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::PKNINEPKILO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x4066770", Offset = "0x4065B70", VA = "0x184066770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x2A3FCF0", Offset = "0x2A3F0F0", VA = "0x182A3FCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim EMBHKCNABIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T JEMKFKHLCMP;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int FLDBMPGPAJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3D5DC00", Offset = "0x3D5D000", VA = "0x183D5DC00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3D5DCA0", Offset = "0x3D5D0A0", VA = "0x183D5DCA0")]
	public PKNINEPKILO(in T JEMKFKHLCMP, int FCHGNKFDHLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3D5DDE0", Offset = "0x3D5D1E0", VA = "0x183D5DDE0")]
	public PKNINEPKILO(in T JEMKFKHLCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3D5DC60", Offset = "0x3D5D060", VA = "0x183D5DC60")]
	public IOILGACIPBC KBFOILNPNOK()
	{
		return default(IOILGACIPBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3D5DC20", Offset = "0x3D5D020", VA = "0x183D5DC20")]
	public IOILGACIPBC KBFOILNPNOK(CancellationToken MJMCKAGGCOI)
	{
		return default(IOILGACIPBC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3D5D660", Offset = "0x3D5CA60", VA = "0x183D5D660")]
	[AsyncStateMachine(typeof(global::PKNINEPKILO<>.OJCDGBOMJPJ))]
	public Task<IOILGACIPBC> COINABJLIDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3D5DA90", Offset = "0x3D5CE90", VA = "0x183D5DA90")]
	[AsyncStateMachine(typeof(global::PKNINEPKILO<>.CIGNCCONEIC))]
	public Task<IOILGACIPBC> COINABJLIDB(CancellationToken MJMCKAGGCOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GBLDFILAFGM
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6465F00", Offset = "0x6465300", VA = "0x186465F00")]
	public static global::PKNINEPKILO<HOGMLAALAEJ> GEGCLDEHDAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6465F60", Offset = "0x6465360", VA = "0x186465F60")]
	public static global::PKNINEPKILO<HOGMLAALAEJ> GEGCLDEHDAN(int FCHGNKFDHLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x296CF40", Offset = "0x296C340", VA = "0x18296CF40")]
	public static global::PKNINEPKILO<T> GEGCLDEHDAN<T>(in T JEMKFKHLCMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2DB8F00", Offset = "0x2DB8300", VA = "0x182DB8F00")]
	public static global::PKNINEPKILO<T> GEGCLDEHDAN<T>(in T JEMKFKHLCMP, int FCHGNKFDHLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class MEHADPLHIMF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> NAHOABMBIBH(TRequest PJJLMKEBMEE, CancellationToken MJMCKAGGCOI);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum LJCFIKHNCGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class GNIEBFPOCIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float GCFMFHAFDHG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan KOMOKPBMFII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int PEOODHJOEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public LJCFIKHNCGK NKCNGLJLOFA;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly GNIEBFPOCIP OKLBJLNFLNK;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float CGONOLNJLLC
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x33A97F0", Offset = "0x33A8BF0", VA = "0x1833A97F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan PMJJLEKKIMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x33A9940", Offset = "0x33A8D40", VA = "0x1833A9940")]
		public GNIEBFPOCIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct BPGAKFICNOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest PJJLMKEBMEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken MJMCKAGGCOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> EPKNDDMKEEK;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x31EF500", Offset = "0x31EE900", VA = "0x1831EF500")]
		public BPGAKFICNOE(TRequest PJJLMKEBMEE, TaskCompletionSource<TResult> EPKNDDMKEEK, CancellationToken MJMCKAGGCOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class LFBMEFMPNGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public LFBMEFMPNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x27EABD0", Offset = "0x27E9FD0", VA = "0x1827EABD0")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct JDOGHGKKINK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::MEHADPLHIMF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x32724D0", Offset = "0x32718D0", VA = "0x1832724D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct GBONPAPBCAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::MEHADPLHIMF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private BPGAKFICNOE <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x338E910", Offset = "0x338DD10", VA = "0x18338E910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x885630", Offset = "0x884A30", VA = "0x180885630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource PLPOBMCILBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<BPGAKFICNOE> LIONLHKDCNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly GNIEBFPOCIP ACJAKGNAKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly NAHOABMBIBH HDNBFDOKJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task BOODKINOMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int IPCDJJHPPMH;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x37F6870", Offset = "0x37F5C70", VA = "0x1837F6870")]
	public MEHADPLHIMF(NAHOABMBIBH HDNBFDOKJCN, [Optional] GNIEBFPOCIP ACJAKGNAKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x37F6050", Offset = "0x37F5450", VA = "0x1837F6050")]
	public Task<TResult> JBLJHPBJGFO(TRequest PJJLMKEBMEE, CancellationToken MJMCKAGGCOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x37F5A70", Offset = "0x37F4E70", VA = "0x1837F5A70")]
	private void FDNHGJAPKDK(BPGAKFICNOE FAKLNFFGKOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x37F58C0", Offset = "0x37F4CC0", VA = "0x1837F58C0")]
	[AsyncStateMachine(typeof(global::MEHADPLHIMF<, >.JDOGHGKKINK))]
	private Task EEFODKHLGJJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x37F5430", Offset = "0x37F4830", VA = "0x1837F5430")]
	private BPGAKFICNOE CMCEJPJLBCF()
	{
		return default(BPGAKFICNOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x37F62A0", Offset = "0x37F56A0", VA = "0x1837F62A0")]
	[AsyncStateMachine(typeof(global::MEHADPLHIMF<, >.GBONPAPBCAC))]
	private Task MHPHBNACBKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x37F6600", Offset = "0x37F5A00", VA = "0x1837F6600")]
	private void OGDJOCJOCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x37F5680", Offset = "0x37F4A80", VA = "0x1837F5680", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class DECNFNEBEAJ<TKey, TVal> : global::NGPBMLMCGED<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int EMCFFFPPKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> NMOBGNBILDD;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int BOJIDEBINKG
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3510530", Offset = "0x350F930", VA = "0x183510530", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int GJBMCGEJFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3510560", Offset = "0x350F960", VA = "0x183510560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3510450", Offset = "0x350F850", VA = "0x183510450", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x35107E0", Offset = "0x350FBE0", VA = "0x1835107E0")]
	public DECNFNEBEAJ(int NANBMPFBPOK, [Optional] OCOJIAFGCAN ACELMKFFIDP, [Optional] IEqualityComparer<TKey> IOJILKLFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3510590", Offset = "0x350F990", VA = "0x183510590")]
	public void KAPAEBFODEK(TKey NPBDKCONLNC, TVal FPLJCBGEJAP, bool IBCJOHIJNHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x35104B0", Offset = "0x350F8B0", VA = "0x1835104B0")]
	public bool GJDPEFNDJHH(TKey NPBDKCONLNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3510740", Offset = "0x350FB40", VA = "0x183510740", Slot = "6")]
	public override bool MPHIBFICBKB(TKey BLNCPPGLJKJ, out TVal FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x35101A0", Offset = "0x350F5A0", VA = "0x1835101A0")]
	public bool BJBPGMMNPMF(TKey NPBDKCONLNC, TVal FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3510630", Offset = "0x350FA30", VA = "0x183510630")]
	public bool LCKOBAKPHCA(TKey NPBDKCONLNC, TVal FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3510130", Offset = "0x350F530", VA = "0x183510130", Slot = "7")]
	public override void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x35103B0", Offset = "0x350F7B0", VA = "0x1835103B0")]
	private bool CKCOALDBABK(TKey NPBDKCONLNC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class NGPBMLMCGED<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate int OCOJIAFGCAN(TKey NPBDKCONLNC, TVal FPLJCBGEJAP);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class BGBBHFFKDHI
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey BBKANMJFKFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x7EE2A0", Offset = "0x7ED6A0", VA = "0x1807EE2A0")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal EJBPMDLBLGL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x75A350", Offset = "0x759750", VA = "0x18075A350")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x762C90", Offset = "0x762090", VA = "0x180762C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int NEINKDNDOKH
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x78F500", Offset = "0x78E900", VA = "0x18078F500")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x75DDF0", Offset = "0x75D1F0", VA = "0x18075DDF0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime JEDBIJFAAHM
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x7776C0", Offset = "0x776AC0", VA = "0x1807776C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x31D0740", Offset = "0x31CFB40", VA = "0x1831D0740")]
		public BGBBHFFKDHI(TKey NPBDKCONLNC, TVal MMHJJFKDNDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int DDOMCCPBKOL = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<BGBBHFFKDHI>> PLBAHPOLLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<BGBBHFFKDHI> MLAODNLIPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly OCOJIAFGCAN ACELMKFFIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan JPNFHJNFIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly MPBMDPGNPDI NFFAOLCLFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int GFAPHGEJPMK;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LPHNGEMLJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7CABB0", Offset = "0x7C9FB0", VA = "0x1807CABB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool LPHNGHNLCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x3346850", Offset = "0x3345C50", VA = "0x183346850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int BOJIDEBINKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7876D0", Offset = "0x786AD0", VA = "0x1807876D0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int NDNADCNCIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x2B3DFE0", Offset = "0x2B3D3E0", VA = "0x182B3DFE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x2CCA6B0", Offset = "0x2CC9AB0", VA = "0x182CCA6B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> JIEPJEOPLPD
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x3345A10", Offset = "0x3344E10", VA = "0x183345A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F9F320", Offset = "0x3F9E720", VA = "0x183F9F320")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3F9FF50", Offset = "0x3F9F350", VA = "0x183F9FF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0080", Offset = "0x3F9F480", VA = "0x183FA0080")]
	public NGPBMLMCGED(int NANBMPFBPOK, [Optional] OCOJIAFGCAN ACELMKFFIDP, [Optional] IEqualityComparer<TKey> IOJILKLFHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x33470A0", Offset = "0x33464A0", VA = "0x1833470A0")]
	public NGPBMLMCGED(TimeSpan JPNFHJNFIIC, [Optional] IEqualityComparer<TKey> IOJILKLFHEP, [Optional] MPBMDPGNPDI NFFAOLCLFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3346D00", Offset = "0x3346100", VA = "0x183346D00")]
	public NGPBMLMCGED(int NANBMPFBPOK, TimeSpan JPNFHJNFIIC, [Optional] IEqualityComparer<TKey> IOJILKLFHEP, [Optional] MPBMDPGNPDI NFFAOLCLFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0150", Offset = "0x3F9F550", VA = "0x183FA0150")]
	public NGPBMLMCGED(int NANBMPFBPOK, OCOJIAFGCAN ACELMKFFIDP, TimeSpan JPNFHJNFIIC, [Optional] IEqualityComparer<TKey> IOJILKLFHEP, [Optional] MPBMDPGNPDI NFFAOLCLFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F360", Offset = "0x3F9E760", VA = "0x183F9F360")]
	public void CEJEDMBLAGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F4E0", Offset = "0x3F9E8E0", VA = "0x183F9F4E0")]
	public void CODPHMBGNGD(TKey NPBDKCONLNC, TVal FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F8D0", Offset = "0x3F9ECD0", VA = "0x183F9F8D0")]
	public bool GAMANBAONBG(TKey NPBDKCONLNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FF90", Offset = "0x3F9F390", VA = "0x183F9FF90")]
	private TVal PEBNPJONHNJ(TKey BLNCPPGLJKJ)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FDE0", Offset = "0x3F9F1E0", VA = "0x183F9FDE0", Slot = "6")]
	public virtual bool MPHIBFICBKB(TKey BLNCPPGLJKJ, out TVal FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x33443D0", Offset = "0x33437D0", VA = "0x1833443D0", Slot = "7")]
	public virtual void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F810", Offset = "0x3F9EC10", VA = "0x183F9F810")]
	private bool FEBPPBNGMLA(BGBBHFFKDHI BGOIBEAAIGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3F9F5C0", Offset = "0x3F9E9C0", VA = "0x183F9F5C0")]
	private void DIMMJPDOIBH(LinkedListNode<BGBBHFFKDHI> CBNGMJHFGAF, TVal OIOCGOCBAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FBE0", Offset = "0x3F9EFE0", VA = "0x183F9FBE0")]
	private void KLKEPONKDMN(TKey NPBDKCONLNC, TVal FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3F9FA40", Offset = "0x3F9EE40", VA = "0x183F9FA40")]
	private void IAGKIKGLBCB(BGBBHFFKDHI BGOIBEAAIGN, TVal OIOCGOCBAJE, int IPFOAOPHDFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class HLPNOFKJLJE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> JOLFKOMKBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> NKOJLGDOGJI;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x27EABD0", Offset = "0x27E9FD0", VA = "0x1827EABD0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HINCDHEAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED0", Offset = "0x6C62D0", VA = "0x1806C6ED0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x31DC090", Offset = "0x31DB490", VA = "0x1831DC090", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x45C2360", Offset = "0x45C1760", VA = "0x1845C2360", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x32296B0", Offset = "0x3228AB0", VA = "0x1832296B0", Slot = "11")]
	public void Add(T GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x45C2170", Offset = "0x45C1570", VA = "0x1845C2170")]
	public bool PPNDICAMACE(T GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x45C22E0", Offset = "0x45C16E0", VA = "0x1845C22E0", Slot = "15")]
	public bool Remove(T GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x39B85C0", Offset = "0x39B79C0", VA = "0x1839B85C0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x2CD0BF0", Offset = "0x2CCFFF0", VA = "0x182CD0BF0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4199560", Offset = "0x4198960", VA = "0x184199560", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x33A5380", Offset = "0x33A4780", VA = "0x1833A5380", Slot = "13")]
	public bool Contains(T GABBPODJMBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x41995C0", Offset = "0x41989C0", VA = "0x1841995C0", Slot = "14")]
	public void CopyTo(T[] OGMMNHCCDJE, int HCDIEBFNKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3232490", Offset = "0x3231890", VA = "0x183232490", Slot = "6")]
	public int IndexOf(T GABBPODJMBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x45C1FE0", Offset = "0x45C13E0", VA = "0x1845C1FE0", Slot = "7")]
	public void Insert(int GABJOMFFJAI, T GABBPODJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x45C2210", Offset = "0x45C1610", VA = "0x1845C2210", Slot = "8")]
	public void RemoveAt(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x45C20A0", Offset = "0x45C14A0", VA = "0x1845C20A0")]
	public void OFKADAKIPPP(Predicate<T> MGGCBNJHBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4199530", Offset = "0x4198930", VA = "0x184199530")]
	public void AHBGFFIOFMJ(Comparison<T> NKMMHBBBJLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x41999A0", Offset = "0x4198DA0", VA = "0x1841999A0")]
	public HLPNOFKJLJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class KCPPPCAIKLC
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6467740", Offset = "0x6466B40", VA = "0x186467740")]
	public static Vector3 NMDOFPLPKDI(this GameObject CEPEJEHMODM, float HILGGPBBIFN)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
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
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xB89D00", Offset = "0xB89100", VA = "0x180B89D00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x191EA90", Offset = "0x191DE90", VA = "0x18191EA90")]
		public SerializedGuid(in Guid CFOLAEKFCNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x646C150", Offset = "0x646B550", VA = "0x18646C150")]
		public static SerializedGuid OCKPMNKCKIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x646BE10", Offset = "0x646B210", VA = "0x18646BE10")]
		public static SerializedGuid CEPHOIDONLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x646BEA0", Offset = "0x646B2A0", VA = "0x18646BEA0")]
		public bool DLHPHEPOECD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x191EA60", Offset = "0x191DE60", VA = "0x18191EA60", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x646C1E0", Offset = "0x646B5E0", VA = "0x18646C1E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x646C0C0", Offset = "0x646B4C0", VA = "0x18646C0C0")]
		public bool LNPLILOIFFP(in Guid CFOLAEKFCNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x646BF30", Offset = "0x646B330", VA = "0x18646BF30", Slot = "7")]
		public bool Equals(SerializedGuid FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x646BFE0", Offset = "0x646B3E0", VA = "0x18646BFE0", Slot = "0")]
		public override bool Equals(object JGHFLANLLNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x191E9B0", Offset = "0x191DDB0", VA = "0x18191E9B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x191E7F0", Offset = "0x191DBF0", VA = "0x18191E7F0", Slot = "6")]
		public int CompareTo(SerializedGuid FJLHJLAMLMA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class GHKPDIBCNLL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type JKGPPGAODMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string DMCGAEKHICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool PNNEGEICFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool ABPEPFJOHDH;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6465FD0", Offset = "0x64653D0", VA = "0x186465FD0")]
	public GHKPDIBCNLL(Type OJLFMHILHHG, string CDJMANHBNBC, bool IHCENFNMGPL = false, bool PDBAIKEOELI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface GLFLNJFKBKL
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface CEJDAFOJGLH<T> : GLFLNJFKBKL
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool IHPFIABJEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string FJMKLADBHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::CEJDAFOJGLH<T> FLHCNCLKOBP(Action<T> GKPODDPBKAI);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::CEJDAFOJGLH<T> HONAIJADOKO(Action<T> GKPODDPBKAI);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::CEJDAFOJGLH<T> EMBIJKPBMHM(Action<T, T> OECANHHLHGN);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::CEJDAFOJGLH<T> BMNFAOKAMAP(Action<T, T> OECANHHLHGN);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::CEJDAFOJGLH<T> CHOCFJCDBAC(Action<string> GBLNIMLJKAL);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::CEJDAFOJGLH<T> PFHFILIEFGJ(Action<string> GBLNIMLJKAL);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HBLJGJELFCG<T> : global::CEJDAFOJGLH<T>, GLFLNJFKBKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::JOCEIKBAJFB<T, T> PCAHILLCLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::EGMEAJPGDMB<T> EHEBMKKJKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::EGMEAJPGDMB<string> FBMGCAGIKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string MCGMECECHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T CGKNIAMFPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool BCLBPHAIBBC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T EJBPMDLBLGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x27EBE60", Offset = "0x27EB260", VA = "0x1827EBE60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool IHPFIABJEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x782DE0", Offset = "0x7821E0", VA = "0x180782DE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string FJMKLADBHHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x318F410", Offset = "0x318E810", VA = "0x18318F410", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x43925A0", Offset = "0x43919A0", VA = "0x1843925A0")]
	private void JGDEPBFEPKN(T OCMDFIDHJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x43926F0", Offset = "0x4391AF0", VA = "0x1843926F0")]
	private void NPJKDCJJJGP(string CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x4392640", Offset = "0x4391A40", VA = "0x184392640")]
	public void LMINFOAGFJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x4392470", Offset = "0x4391870", VA = "0x184392470", Slot = "6")]
	public global::CEJDAFOJGLH<T> EMBIJKPBMHM(Action<T, T> OECANHHLHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x4392380", Offset = "0x4391780", VA = "0x184392380", Slot = "7")]
	public global::CEJDAFOJGLH<T> BMNFAOKAMAP(Action<T, T> OECANHHLHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x43924C0", Offset = "0x43918C0", VA = "0x1843924C0", Slot = "4")]
	public global::CEJDAFOJGLH<T> FLHCNCLKOBP(Action<T> OECANHHLHGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x4392550", Offset = "0x4391950", VA = "0x184392550", Slot = "5")]
	public global::CEJDAFOJGLH<T> HONAIJADOKO(Action<T> GKPODDPBKAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x43923D0", Offset = "0x43917D0", VA = "0x1843923D0", Slot = "8")]
	public global::CEJDAFOJGLH<T> CHOCFJCDBAC(Action<string> GBLNIMLJKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x43927A0", Offset = "0x4391BA0", VA = "0x1843927A0", Slot = "9")]
	public global::CEJDAFOJGLH<T> PFHFILIEFGJ(Action<string> GBLNIMLJKAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4392810", Offset = "0x4391C10", VA = "0x184392810")]
	public HBLJGJELFCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class DOKEBLOOGAP
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class NDFBEAKMIAB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::CEJDAFOJGLH<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::FEKGIBNPEAH<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public NDFBEAKMIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x3F94510", Offset = "0x3F93910", VA = "0x183F94510")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x33EA050", Offset = "0x33E9450", VA = "0x1833EA050")]
	public static global::HPHDJAFFHCN<T> ECDBBAKEJAB<T>(this global::CEJDAFOJGLH<T> BPHKNHADNGC, Action<T> KCKLDKHBENC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class PADKJAANMNM<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct PNHDOMMPKKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long LKBOGPLMEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long ONDACOILJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int GNGGCIJFHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int JPAFGGDEOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool ACANLNCOPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string PPBHFIONIHO;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x32D66E0", Offset = "0x32D5AE0", VA = "0x1832D66E0")]
		public PNHDOMMPKKJ(long LKBOGPLMEJJ, int GNGGCIJFHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x32D6750", Offset = "0x32D5B50", VA = "0x1832D6750")]
		public PNHDOMMPKKJ(long LKBOGPLMEJJ, long ONDACOILJMM, int GNGGCIJFHOE, int JPAFGGDEOHO, bool ACANLNCOPCM, string PPBHFIONIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x32D6670", Offset = "0x32D5A70", VA = "0x1832D6670")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void PBBILLBBJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x32D6500", Offset = "0x32D5900", VA = "0x1832D6500")]
		public int BOMNKMCFEOD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x32D6550", Offset = "0x32D5950", VA = "0x1832D6550")]
		public int MILEADECCNN(int NAOCMCJEJPD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x32D6600", Offset = "0x32D5A00", VA = "0x1832D6600")]
		public double OMABACDOEBA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x32D6570", Offset = "0x32D5970", VA = "0x1832D6570")]
		public PNHDOMMPKKJ MLMAAENFGEO(long ONDACOILJMM, int JPAFGGDEOHO)
		{
			return default(PNHDOMMPKKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class MIPBMMJKKCH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey BBKANMJFKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::PADKJAANMNM<TKey> HMHNEOCJGLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<MIPBMMJKKCH> PGAFNOFMNON;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string FHBDEFMEPHK
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x252B2A0", Offset = "0x252A6A0", VA = "0x18252B2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x252B050", Offset = "0x252A450", VA = "0x18252B050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<MIPBMMJKKCH> MKGCJNINDKA
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x380FE80", Offset = "0x380F280", VA = "0x18380FE80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public PNHDOMMPKKJ MLMNNNJDALM
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xAFA720", Offset = "0xAF9B20", VA = "0x180AFA720")]
			[CompilerGenerated]
			get
			{
				return default(PNHDOMMPKKJ);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x380FE50", Offset = "0x380F250", VA = "0x18380FE50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x380FF80", Offset = "0x380F380", VA = "0x18380FF80")]
		internal MIPBMMJKKCH(global::PADKJAANMNM<TKey> HMHNEOCJGLO, TKey NPBDKCONLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x380FB90", Offset = "0x380EF90", VA = "0x18380FB90")]
		public MIPBMMJKKCH DMKAJDOMLKN(TKey NPBDKCONLNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x380FEA0", Offset = "0x380F2A0", VA = "0x18380FEA0")]
		public void MMCKFBAHGEO(TKey NPBDKCONLNC, Action<MIPBMMJKKCH> EFFJGLADCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3100080", Offset = "0x30FF480", VA = "0x183100080")]
		public T MMCKFBAHGEO<T>(TKey NPBDKCONLNC, Func<MIPBMMJKKCH, T> BKAPBNHJDFL)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3100170", Offset = "0x30FF570", VA = "0x183100170")]
		[AsyncStateMachine(typeof(CIDMFCJOLMK))]
		public Task<T> NLPDGDHBAIA<T>(TKey NPBDKCONLNC, Func<MIPBMMJKKCH, Task<T>> BKAPBNHJDFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x380FCA0", Offset = "0x380F0A0", VA = "0x18380FCA0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class FIEMBJAKFIP : IEnumerable<(TKey, List<TKey>, PNHDOMMPKKJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, PNHDOMMPKKJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, PNHDOMMPKKJ timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::PADKJAANMNM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, PNHDOMMPKKJ timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, PNHDOMMPKKJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x38ED220", Offset = "0x38EC620", VA = "0x1838ED220", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, PNHDOMMPKKJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x41088D0", Offset = "0x4107CD0", VA = "0x1841088D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x38ED480", Offset = "0x38EC880", VA = "0x1838ED480")]
		[DebuggerHidden]
		public FIEMBJAKFIP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2CC9640", Offset = "0x2CC8A40", VA = "0x182CC9640", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x41084B0", Offset = "0x41078B0", VA = "0x1841084B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x4108930", Offset = "0x4107D30", VA = "0x184108930")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x4108890", Offset = "0x4107C90", VA = "0x184108890", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x41087D0", Offset = "0x4107BD0", VA = "0x1841087D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, PNHDOMMPKKJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x27EC740", Offset = "0x27EBB40", VA = "0x1827EC740", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class GBBPMEJBPFM : IEnumerable<(TKey, List<TKey>, PNHDOMMPKKJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, PNHDOMMPKKJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, PNHDOMMPKKJ timerEntry) <>2__current;

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
		private MIPBMMJKKCH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public MIPBMMJKKCH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::PADKJAANMNM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<MIPBMMJKKCH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, PNHDOMMPKKJ timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, PNHDOMMPKKJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x38ED220", Offset = "0x38EC620", VA = "0x1838ED220", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, PNHDOMMPKKJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x38ED2C0", Offset = "0x38EC6C0", VA = "0x1838ED2C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x38ED480", Offset = "0x38EC880", VA = "0x1838ED480")]
		[DebuggerHidden]
		public GBBPMEJBPFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x38ED320", Offset = "0x38EC720", VA = "0x1838ED320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x38ECBA0", Offset = "0x38EBFA0", VA = "0x1838ECBA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x38ED3C0", Offset = "0x38EC7C0", VA = "0x1838ED3C0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x38ED420", Offset = "0x38EC820", VA = "0x1838ED420")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x38ED280", Offset = "0x38EC680", VA = "0x1838ED280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x38ED140", Offset = "0x38EC540", VA = "0x1838ED140", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, PNHDOMMPKKJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x38ED250", Offset = "0x38EC650", VA = "0x1838ED250", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, PNHDOMMPKKJ> MNDDCBOPKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, PNHDOMMPKKJ> AHICKAOKGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::PADKJAANMNM<TKey>> LBKFOIIDHDO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string ABMLPJFEGMK = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly MIPBMMJKKCH FOIGMDMLFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool MDPNAAPBFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int GKDJEPAHJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch HFDOHNNPLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int ONGLNBFIGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string JIOOFNEFLNA;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public MIPBMMJKKCH CJFJFDLFOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C6260", Offset = "0x6C5660", VA = "0x1806C6260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string FHBDEFMEPHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1530", Offset = "0x6E0930", VA = "0x1806E1530")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x3FE98F0", Offset = "0x3FE8CF0", VA = "0x183FE98F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long AKCIGPFDJMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3FE9790", Offset = "0x3FE8B90", VA = "0x183FE9790")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int OFBPNLBOOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3FE97B0", Offset = "0x3FE8BB0", VA = "0x183FE97B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9AF0", Offset = "0x3FE8EF0", VA = "0x183FE9AF0")]
	public PADKJAANMNM(TKey KEHEOOOIGJC, [Optional] int? GNGGCIJFHOE, [Optional][CanBeNull] Stopwatch HFDOHNNPLHD, [Optional] Action<TKey, PNHDOMMPKKJ> MNDDCBOPKHI, [Optional] Action<TKey, PNHDOMMPKKJ> AHICKAOKGJK, [Optional] Action<global::PADKJAANMNM<TKey>> LBKFOIIDHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x3FE97E0", Offset = "0x3FE8BE0", VA = "0x183FE97E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9950", Offset = "0x3FE8D50", VA = "0x183FE9950")]
	public void MGFEJKFJGGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9AD0", Offset = "0x3FE8ED0", VA = "0x183FE9AD0")]
	public void MPGBJDGJFGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9A40", Offset = "0x3FE8E40", VA = "0x183FE9A40")]
	[IteratorStateMachine(typeof(global::PADKJAANMNM<>.FIEMBJAKFIP))]
	public IEnumerable<(TKey, List<TKey>, PNHDOMMPKKJ)> MIDFELNGNKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9970", Offset = "0x3FE8D70", VA = "0x183FE9970")]
	[IteratorStateMachine(typeof(global::PADKJAANMNM<>.GBBPMEJBPFM))]
	private IEnumerable<(TKey, List<TKey>, PNHDOMMPKKJ)> MIDFELNGNKF(List<TKey> NMGICKMLDFI, MIPBMMJKKCH JPHACINCAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3FE9870", Offset = "0x3FE8C70", VA = "0x183FE9870")]
	private (long, int) KEEOMCBFPKC()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class KMCKPABDFNH<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JPMPPMMICFP(global::PADKJAANMNM<TKey> HMHNEOCJGLO);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
	protected KMCKPABDFNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class BPKNNIGHPGC<TKey> : global::KMCKPABDFNH<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate string IGNBGNIDCHN(TKey NPBDKCONLNC);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x31F1A40", Offset = "0x31F0E40", VA = "0x1831F1A40")]
	protected string HPGJAEKIANJ(double MPLGJLPILDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x31F19E0", Offset = "0x31F0DE0", VA = "0x1831F19E0")]
	protected string BJJJGJFHICB(int PANKBLBBDDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x31F1C90", Offset = "0x31F1090", VA = "0x1831F1C90")]
	private static string PDAHDGDEPDG(TKey NPBDKCONLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x31F1BE0", Offset = "0x31F0FE0", VA = "0x1831F1BE0", Slot = "4")]
	public override string JPMPPMMICFP(global::PADKJAANMNM<TKey> HMHNEOCJGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x31F1AB0", Offset = "0x31F0EB0", VA = "0x1831F1AB0")]
	public string JPMPPMMICFP(global::PADKJAANMNM<TKey> HMHNEOCJGLO, [NotNull] IGNBGNIDCHN KODBAJFFJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BLJKCFPMFND(global::PADKJAANMNM<TKey> HMHNEOCJGLO, [NotNull] IGNBGNIDCHN KODBAJFFJMN);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x31F1CD0", Offset = "0x31F10D0", VA = "0x1831F1CD0")]
	protected BPKNNIGHPGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class LBDEDMGFHDK<TKey> : global::KMCKPABDFNH<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate string JFJJGDKNDNM(TKey NPBDKCONLNC);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int KOPLEEDPGJE = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string NKONCKNLANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double DCDDCJCKKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool PMCGPPIBNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int JFPOFGLGBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> JHALBOGOFDO;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D570", Offset = "0x2E8C970", VA = "0x182E8D570")]
	private static string PDAHDGDEPDG(TKey NPBDKCONLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D5B0", Offset = "0x2E8C9B0", VA = "0x182E8D5B0")]
	public LBDEDMGFHDK(string NKONCKNLANK = "F2", double DCDDCJCKKID = double.MaxValue, bool PMCGPPIBNNN = false, int JFPOFGLGBML = int.MaxValue, [Optional] ISet<string> JHALBOGOFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x2E8CEA0", Offset = "0x2E8C2A0", VA = "0x182E8CEA0", Slot = "4")]
	public override Dictionary<string, string> JPMPPMMICFP(global::PADKJAANMNM<TKey> HMHNEOCJGLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x2E8D490", Offset = "0x2E8C890", VA = "0x182E8D490")]
	private bool KJKIDPJMKHO(string KEEPJKIBGMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x2E8CF50", Offset = "0x2E8C350", VA = "0x182E8CF50")]
	public Dictionary<string, string> JPMPPMMICFP(global::PADKJAANMNM<TKey> HMHNEOCJGLO, JFJJGDKNDNM KODBAJFFJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x2E8CCF0", Offset = "0x2E8C0F0", VA = "0x182E8CCF0")]
	private string JHMOIBOCCAD(StringBuilder ECMOFACFHAF, List<TKey> DDKAPONEOGL, JFJJGDKNDNM KODBAJFFJMN, bool CPKEGGAIIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x2E8CB70", Offset = "0x2E8BF70", VA = "0x182E8CB70")]
	private static void EHHGNLMNIOJ(StringBuilder OCDJAPGKPJC, string HOOCFNBADBK, bool FBGNJNOMOAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NJONPGNLJJN<TKey> : global::BPKNNIGHPGC<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct LJENILCOGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public IGNBGNIDCHN keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::NJONPGNLJJN<TKey> KGGJIHLJBIH;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int DJOEHLLNHIB = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] JBLBCAEHDFD;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x334AC30", Offset = "0x334A030", VA = "0x18334AC30")]
	private NJONPGNLJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x3349B50", Offset = "0x3348F50", VA = "0x183349B50", Slot = "5")]
	protected override string BLJKCFPMFND(global::PADKJAANMNM<TKey> HMHNEOCJGLO, IGNBGNIDCHN KODBAJFFJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x334AA40", Offset = "0x3349E40", VA = "0x18334AA40")]
	[CompilerGenerated]
	internal static string PMDAIGOHCEP(string BCEBCJCKNFO, TKey NPBDKCONLNC, ref LJENILCOGJP P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class FLABHKOCNNK<TKey> : global::BPKNNIGHPGC<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class CEBLHCABAJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public IGNBGNIDCHN keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public CEBLHCABAJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E610", Offset = "0x2B3DA10", VA = "0x182B3E610")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x3E94FD0", Offset = "0x3E943D0", VA = "0x183E94FD0", Slot = "5")]
	protected override string BLJKCFPMFND(global::PADKJAANMNM<TKey> HMHNEOCJGLO, IGNBGNIDCHN KODBAJFFJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x39B8780", Offset = "0x39B7B80", VA = "0x1839B8780")]
	public FLABHKOCNNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class ELGKOFCLCNI : global::PADKJAANMNM<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class ADFAIEGPCOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<ELGKOFCLCNI> callback;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ADFAIEGPCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x64631A0", Offset = "0x64625A0", VA = "0x1864631A0")]
		internal void <Wrap>b__0(global::PADKJAANMNM<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6464CA0", Offset = "0x64640A0", VA = "0x186464CA0")]
	public ELGKOFCLCNI([Optional] string LMAGPOPKGCP, [Optional] int? GNGGCIJFHOE, [Optional] Stopwatch HFDOHNNPLHD, [Optional] Action<string, PNHDOMMPKKJ> MNDDCBOPKHI, [Optional] Action<string, PNHDOMMPKKJ> AHICKAOKGJK, [Optional] Action<ELGKOFCLCNI> LBKFOIIDHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6464BC0", Offset = "0x6463FC0", VA = "0x186464BC0")]
	private static Action<global::PADKJAANMNM<string>> MMCKFBAHGEO(Action<ELGKOFCLCNI> KCKLDKHBENC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class MPBMDPGNPDI
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class ELJAHJEPOBD : MPBMDPGNPDI
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static MPBMDPGNPDI KGGJIHLJBIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x6464E40", Offset = "0x6464240", VA = "0x186464E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime IMPCFCBFKFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x6464DF0", Offset = "0x64641F0", VA = "0x186464DF0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float JOHLNNHDOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1A44B30", Offset = "0x1A43F30", VA = "0x181A44B30", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6464F40", Offset = "0x6464340", VA = "0x186464F40")]
		public ELJAHJEPOBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static MPBMDPGNPDI NPPNDKIIPOM;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static MPBMDPGNPDI OKLBJLNFLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6467EF0", Offset = "0x64672F0", VA = "0x186467EF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime IMPCFCBFKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float JOHLNNHDOOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	protected MPBMDPGNPDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EBMBODBPLKP : global::JBPNJOMODNJ<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6464730", Offset = "0x6463B30", VA = "0x186464730")]
	public EBMBODBPLKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JBPNJOMODNJ<T> : global::EBFIFOIIIII<T>, HKEMFAHKOKG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> HOHDFHNOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task KMHBONKADGN
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x21AEE40", Offset = "0x21AE240", VA = "0x1821AEE40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::HPHDJAFFHCN<T> EOONOHAMHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private NDNJBANLHJC DJFKGCPCPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x2525360", Offset = "0x2524760", VA = "0x182525360", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x3F4C3B0", Offset = "0x3F4B7B0", VA = "0x183F4C3B0")]
	public JBPNJOMODNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EBIEFLMGJIF : global::MKDENNMKNID<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x64646E0", Offset = "0x6463AE0", VA = "0x1864646E0")]
	public EBIEFLMGJIF(Exception EPPMCIFCHBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class MKDENNMKNID<T> : global::EBFIFOIIIII<T>, HKEMFAHKOKG, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> HOHDFHNOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task KMHBONKADGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x21AEE40", Offset = "0x21AE240", VA = "0x1821AEE40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::HPHDJAFFHCN<T> EOONOHAMHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private NDNJBANLHJC DJFKGCPCPKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x2525360", Offset = "0x2524760", VA = "0x182525360", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x35EA240", Offset = "0x35E9640", VA = "0x1835EA240")]
	public MKDENNMKNID(Exception EPPMCIFCHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface HKEMFAHKOKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task HOHDFHNOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	NDNJBANLHJC EOONOHAMHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface EBFIFOIIIII<T> : HKEMFAHKOKG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> HOHDFHNOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::HPHDJAFFHCN<T> EOONOHAMHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class NGKBGCNHCGG<TTask, T> : global::EBFIFOIIIII<T>, HKEMFAHKOKG, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class EAKNPCKIICF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public global::NGKBGCNHCGG<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public EAKNPCKIICF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool MFPECLAAKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> IGPMHCEBGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource NFMAFINMMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool MDPNAAPBFCF;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> HOHDFHNOKFB
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task KMHBONKADGN
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::HPHDJAFFHCN<T> EOONOHAMHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private NDNJBANLHJC DJFKGCPCPKC
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3044320", Offset = "0x3043720", VA = "0x183044320", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool PGGMGHNLHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x8A81C0", Offset = "0x8A75C0", VA = "0x1808A81C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E7D0", Offset = "0x3F9DBD0", VA = "0x183F9E7D0")]
	static NGKBGCNHCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E940", Offset = "0x3F9DD40", VA = "0x183F9E940")]
	protected NGKBGCNHCGG(TTask IGPMHCEBGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E250", Offset = "0x3F9D650", VA = "0x183F9E250", Slot = "1")]
	~NGKBGCNHCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E220", Offset = "0x3F9D620", VA = "0x183F9E220", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x3F9E490", Offset = "0x3F9D890", VA = "0x183F9E490")]
	private void IDPLHJEPBCF(bool DICBNDFMLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T DFIACLKFLMA(TTask DCFGGHHAFBH);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void AIHLCDLFONH();
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface JPMEPLFEOKB
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float DOMCCMPOCJF
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event BNKPPKJPPFB AMEPKCMHGEH;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class NAIIIENIGCP : JPMEPLFEOKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct MALGIFDOKBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public readonly float ABMGALELFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float NCJHNOLPBMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		internal readonly bool NFDBEOJPGBB;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float NEINKDNDOKH
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x6467BC0", Offset = "0x6466FC0", VA = "0x186467BC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6467D50", Offset = "0x6467150", VA = "0x186467D50")]
		public MALGIFDOKBB(float GJOFJPHNEOA, float AFEDLJDCGDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6467BD0", Offset = "0x6466FD0", VA = "0x186467BD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class MAKKDECNIGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public NAIIIENIGCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public MAKKDECNIGB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly int NANBMPFBPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private int CKBFJPMANOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly JPMEPLFEOKB[] ACJNDAGLHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly BNKPPKJPPFB[] CMMLIBKHPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly MALGIFDOKBB[] BAKHFBLBOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private MALGIFDOKBB MLOHOALFCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly NPFGJMKHLLJ FPHBGAKHJHF;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public MALGIFDOKBB AHMAOCNHFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1125A50", Offset = "0x1124E50", VA = "0x181125A50")]
		get
		{
			return default(MALGIFDOKBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float DOMCCMPOCJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6468910", Offset = "0x6467D10", VA = "0x186468910", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event BNKPPKJPPFB AMEPKCMHGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6468850", Offset = "0x6467C50", VA = "0x186468850", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x64684D0", Offset = "0x64678D0", VA = "0x1864684D0", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x6468930", Offset = "0x6467D30", VA = "0x186468930")]
	public NAIIIENIGCP(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x64687C0", Offset = "0x6467BC0", VA = "0x1864687C0")]
	public NPFGJMKHLLJ KLMNBKHKDFB(MALGIFDOKBB MCFECKFIGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6468080", Offset = "0x6467480", VA = "0x186468080")]
	public void APLMFEPFEMC(JPMEPLFEOKB FPFHMHCAGLK, [Optional] MALGIFDOKBB AAJEELHEPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x6468720", Offset = "0x6467B20", VA = "0x186468720")]
	internal int GLKAIEBIFIN(JPMEPLFEOKB JEJJICOONOE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x6468770", Offset = "0x6467B70", VA = "0x186468770")]
	internal MALGIFDOKBB KKIGKKPPBAA(int GABJOMFFJAI)
	{
		return default(MALGIFDOKBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6468590", Offset = "0x6467990", VA = "0x186468590", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void BNKPPKJPPFB(float HJOFIKBMGND);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class OPJJGPGBJPF
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	internal const float NOBKGINFPII = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class NIBICICFCAE
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class HELDJCEBIAE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly JPMEPLFEOKB JEJJICOONOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly BNKPPKJPPFB KCKLDKHBENC;

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6466740", Offset = "0x6465B40", VA = "0x186466740")]
		public HELDJCEBIAE(JPMEPLFEOKB JEJJICOONOE, BNKPPKJPPFB KCKLDKHBENC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x64666F0", Offset = "0x6465AF0", VA = "0x1864666F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6468C40", Offset = "0x6468040", VA = "0x186468C40")]
	internal static bool GOLDNENIJAH(float KEPOHMNFLGL, float CFEKEMJOJGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0180", Offset = "0x4EAF580", VA = "0x184EB0180")]
	internal static float MJPLIMLBJOK(float KEPOHMNFLGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6468B80", Offset = "0x6467F80", VA = "0x186468B80")]
	public static IDisposable DGPLAAMIFBC(this JPMEPLFEOKB JEJJICOONOE, BNKPPKJPPFB KCKLDKHBENC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class NPFGJMKHLLJ : JPMEPLFEOKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float HJOFIKBMGND;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float DOMCCMPOCJF
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x85BD40", Offset = "0x85B140", VA = "0x18085BD40", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6468D60", Offset = "0x6468160", VA = "0x186468D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event BNKPPKJPPFB AMEPKCMHGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6468E20", Offset = "0x6468220", VA = "0x186468E20", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6468CC0", Offset = "0x64680C0", VA = "0x186468CC0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public NPFGJMKHLLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class OGAMBBNDLND
{
	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6469540", Offset = "0x6468940", VA = "0x186469540")]
	[NotNull]
	public static byte[] MEMIGHODLPP(this DJAJPBBFAAD CFDEGBKEMNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x64694D0", Offset = "0x64688D0", VA = "0x1864694D0")]
	[NotNull]
	public static byte[] MEMIGHODLPP(this DJAJPBBFAAD CFDEGBKEMNM, HashAlgorithmName IJOBNGHFEFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6469080", Offset = "0x6468480", VA = "0x186469080")]
	public static bool EINCJPKEBCP([CanBeNull] this DJAJPBBFAAD CFDEGBKEMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6469210", Offset = "0x6468610", VA = "0x186469210")]
	public static bool EINCJPKEBCP([CanBeNull] this DJAJPBBFAAD CFDEGBKEMNM, out string MCGMECECHJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6469010", Offset = "0x6468410", VA = "0x186469010")]
	private static string EHAHBPEKIOL([CanBeNull] byte[] GJDBLJLIDDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x64693B0", Offset = "0x64687B0", VA = "0x1864693B0")]
	private static bool HGMLNKIJGHI([NotNull] DJAJPBBFAAD CFDEGBKEMNM, [CanBeNull] out byte[] NNGFEBACPGD, [CanBeNull] out byte[] NKKLPMEBNND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class HDPIPNPBMNP
{
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6466480", Offset = "0x6465880", VA = "0x186466480")]
	[NotNull]
	public static byte[] MEMIGHODLPP(this BIFJEAMDNDE HHPONGAFMAK, byte[] ODIKAMOCNBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x64664C0", Offset = "0x64658C0", VA = "0x1864664C0")]
	[NotNull]
	public static byte[] MEMIGHODLPP(this BIFJEAMDNDE HHPONGAFMAK, HashAlgorithmName IJOBNGHFEFL, byte[] ODIKAMOCNBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface BIFJEAMDNDE
{
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash FCNILJEDKDH);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface DJAJPBBFAAD : BIFJEAMDNDE
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] GEPJCJKMFIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] NALJKBFLPKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object GAIPCBMIAPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class PIKOMGJAIPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class CIKPIDBGHFD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x6463570", Offset = "0x6462970", VA = "0x186463570")]
		public CIKPIDBGHFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x6463510", Offset = "0x6462910", VA = "0x186463510", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private const byte HHOCIKHGOCA = 1;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte EKLBAMCKAEA = 0;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly ArrayPool<byte> AGCMEBEEHAN;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static bool HBNCEFPCAMN;

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x3B91DC0", Offset = "0x3B911C0", VA = "0x183B91DC0")]
	[Conditional("UNITY_EDITOR")]
	private static void HFJMNBIPIGE<T>(params T[] DAIPNJENAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x646A690", Offset = "0x6469A90", VA = "0x18646A690")]
	public static IDisposable PCIGPDLECFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x6469900", Offset = "0x6468D00", VA = "0x186469900")]
	public static void DBCJCGEBJAE(this IncrementalHash FJFLODFFKFM, [CanBeNull] GameObject CEPEJEHMODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x3B91570", Offset = "0x3B90970", VA = "0x183B91570")]
	public static void DBCJCGEBJAE<T>(this IncrementalHash FJFLODFFKFM, [CanBeNull] T LFAAOBNJLDK) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3B91D30", Offset = "0x3B91130", VA = "0x183B91D30")]
	public static void ENKGPPFDEFF<T>(this IncrementalHash FJFLODFFKFM, [CanBeNull] T HHPONGAFMAK) where T : BIFJEAMDNDE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3B91110", Offset = "0x3B90510", VA = "0x183B91110")]
	public static void BMMEJEJBOKP<T>(this IncrementalHash FJFLODFFKFM, [CanBeNull] IList<T> NKCLIKOPGPO) where T : BIFJEAMDNDE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x646A490", Offset = "0x6469890", VA = "0x18646A490")]
	private static bool NLOLHAHFJCL([CanBeNull] BIFJEAMDNDE HHPONGAFMAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x646A2F0", Offset = "0x64696F0", VA = "0x18646A2F0")]
	public static void KDLCFOIHPEN(this IncrementalHash FCNILJEDKDH, [CanBeNull] string GOBDAHGANOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6469FB0", Offset = "0x64693B0", VA = "0x186469FB0")]
	public static void IAPOOKOPKIK(this IncrementalHash FCNILJEDKDH, long NHMCIIPFEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6469DE0", Offset = "0x64691E0", VA = "0x186469DE0")]
	public static void GJLCCOFMMBF(this IncrementalHash FCNILJEDKDH, int OOFAGDJJPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x64696D0", Offset = "0x6468AD0", VA = "0x1864696D0")]
	public static void AGKCBPJJDCG(this IncrementalHash FCNILJEDKDH, short NNFBKLOFNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x646A520", Offset = "0x6469920", VA = "0x18646A520")]
	public static void OGMMMJCGKDM(this IncrementalHash FCNILJEDKDH, byte CNDHOACJCCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6469C10", Offset = "0x6469010", VA = "0x186469C10")]
	public static void FAPOLFDALEC(this IncrementalHash FCNILJEDKDH, bool HCLMLLCCIJC, bool FGPBLKNHHBC = false, bool NMHMCHLEFFN = false, bool BCGENPHIPJA = false, bool AENCIDAJOBF = false, bool FDGHJGDIILN = false, bool BNEEHPNKCAE = false, bool APDBPPNDIPK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x3B91640", Offset = "0x3B90A40", VA = "0x183B91640")]
	public static void EKFIFCNPIEH<T>(this IncrementalHash FCNILJEDKDH, T EKKBNBNIKJG) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x646A430", Offset = "0x6469830", VA = "0x18646A430")]
	public static void NIJJCJJHBKF(this IncrementalHash FCNILJEDKDH, float HHPLGKMJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x64699F0", Offset = "0x6468DF0", VA = "0x1864699F0")]
	public static void DCFKCDIMHMN(this IncrementalHash FCNILJEDKDH, double OMEJCACJBCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x646A3C0", Offset = "0x64697C0", VA = "0x18646A3C0")]
	public static void MGDIGFGGHOK(this IncrementalHash FCNILJEDKDH, ulong EAMINMPNKCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x64698A0", Offset = "0x6468CA0", VA = "0x1864698A0")]
	public static void CNDIEAFMHKN(this IncrementalHash FCNILJEDKDH, uint HMEPMMNBEKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x646A350", Offset = "0x6469750", VA = "0x18646A350")]
	public static void KLECHINKKAI(this IncrementalHash FCNILJEDKDH, ushort LLNAIDCLHCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x646A180", Offset = "0x6469580", VA = "0x18646A180")]
	public static void JFJKFHBGJKE(this IncrementalHash FCNILJEDKDH, Vector3 ILHAMLGDPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6469A50", Offset = "0x6468E50", VA = "0x186469A50")]
	public static void DKLIMEKHHDJ(this IncrementalHash FCNILJEDKDH, Quaternion GDHLMDOPKIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class MLBMIKPKCFG : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly Type JKGPPGAODMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string DMCGAEKHICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly bool PNNEGEICFCL;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6467E90", Offset = "0x6467290", VA = "0x186467E90")]
	public MLBMIKPKCFG(Type OJLFMHILHHG, string CDJMANHBNBC, bool IHCENFNMGPL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class OFCAMCMHIAB : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6468EC0", Offset = "0x64682C0", VA = "0x186468EC0")]
	public OFCAMCMHIAB(string CIBBLLOHCGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6468F30", Offset = "0x6468330", VA = "0x186468F30")]
	public OFCAMCMHIAB(string CIBBLLOHCGM, Exception IOEKPCFCNII)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x6E4780", Offset = "0x6E3B80", VA = "0x1806E4780")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x7B9670", Offset = "0x7B8A70", VA = "0x1807B9670")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int MDFMPEMHONH, int JPMMBFJNMFP]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x429F250", Offset = "0x429E650", VA = "0x18429F250")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x429F2F0", Offset = "0x429E6F0", VA = "0x18429F2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x429F1C0", Offset = "0x429E5C0", VA = "0x18429F1C0")]
		public Array2D(uint HIPFHAFHMOD, uint BNPPIEMPHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x429F140", Offset = "0x429E540", VA = "0x18429F140")]
		public void BIEFCABEIDG()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x6463340", Offset = "0x6462740", VA = "0x186463340")]
		public Array2DVector3(uint HIPFHAFHMOD, uint BNPPIEMPHIN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct HIFHKKCJLPG
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public delegate bool IECKOELHBLE(string MGHJOAOBODH, HIFHKKCJLPG LNEALNLCBBO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public int EKKBNBNIKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public string HEKIBGCLDFB;

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x64667D0", Offset = "0x6465BD0", VA = "0x1864667D0")]
	public static Dictionary<string, HIFHKKCJLPG> BPKGJHBPGCL(Type AIGKHJDCOHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6466C70", Offset = "0x6466070", VA = "0x186466C70")]
	public static Dictionary<string, HIFHKKCJLPG> KCIEEHBCLKE(Type AIGKHJDCOHH, IECKOELHBLE IMNLEJNAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6466AC0", Offset = "0x6465EC0", VA = "0x186466AC0")]
	public static Dictionary<int, string> DEHBCNGHFPH(Dictionary<string, HIFHKKCJLPG> HNJNABPJHCC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class DCCAPFFOENB
{
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public const int BCIIEGAHHMD = -1;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public const int OJLIGMBNMFE = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class MJIHJJBKGCN<THandle, TValue> : IDisposable where THandle : struct, IKDLAGIDJHG where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly List<THandle> LMKEDMFBABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly List<TValue> LFCHDKPFGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly Func<TValue> HDDKGDDENIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Action<TValue> GKAJEBFGILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private int GKGJBBHFOAN;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x3231B90", Offset = "0x3230F90", VA = "0x183231B90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x35E9A70", Offset = "0x35E8E70", VA = "0x1835E9A70")]
	public MJIHJJBKGCN(Action<TValue> GKAJEBFGILB, [Optional] Func<TValue> HDDKGDDENIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x35E9030", Offset = "0x35E8430", VA = "0x1835E9030", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x38104B0", Offset = "0x380F8B0", VA = "0x1838104B0")]
	public THandle PELCFOCODBC()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x35E8FC0", Offset = "0x35E83C0", VA = "0x1835E8FC0")]
	public THandle BKCAAEBNAMB(TValue FPLJCBGEJAP)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x35E9260", Offset = "0x35E8660", VA = "0x1835E9260")]
	public bool GAMANBAONBG(THandle CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x35E90E0", Offset = "0x35E84E0", VA = "0x1835E90E0")]
	public bool FBEHGKKMCPK(THandle CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x35E94B0", Offset = "0x35E88B0", VA = "0x1835E94B0")]
	public bool KNEMJPBHGAN(THandle CKELBFAAOKG, out TValue FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x35E98A0", Offset = "0x35E8CA0", VA = "0x1835E98A0")]
	public TValue PEBNPJONHNJ(THandle CKELBFAAOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x35E96C0", Offset = "0x35E8AC0", VA = "0x1835E96C0")]
	public bool NDBOIIODAJJ(THandle CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x35E8F90", Offset = "0x35E8390", VA = "0x1835E8F90")]
	private THandle AKOPDLNLNOA(int GABJOMFFJAI)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x35E90B0", Offset = "0x35E84B0", VA = "0x1835E90B0")]
	private TValue ECDBBAKEJAB(int GABJOMFFJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x35E9A30", Offset = "0x35E8E30", VA = "0x1835E9A30")]
	private void PPEJJCDMGLA(int GABJOMFFJAI, in THandle CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x35E9390", Offset = "0x35E8790", VA = "0x1835E9390")]
	private void JGDEPBFEPKN(int GABJOMFFJAI, in TValue FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x35E95B0", Offset = "0x35E89B0", VA = "0x1835E95B0")]
	private THandle MMPCMMKOLBE()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x35E91B0", Offset = "0x35E85B0", VA = "0x1835E91B0")]
	private void FIAGNDDABFK(THandle CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x35E94A0", Offset = "0x35E88A0", VA = "0x1835E94A0")]
	private int KAKMOJDENKI(int IIMAMIPIKFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x35E9770", Offset = "0x35E8B70", VA = "0x1835E9770")]
	private bool NJJKLNCMIFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x9A5810", Offset = "0x9A4C10", VA = "0x1809A5810")]
	private void KOACDLFCDHE(THandle CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x35E9310", Offset = "0x35E8710", VA = "0x1835E9310")]
	private bool IGIJLNHIODA(out THandle CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x35E93D0", Offset = "0x35E87D0", VA = "0x1835E93D0")]
	private bool JNJKOKDCFAD(out THandle CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x35E9550", Offset = "0x35E8950", VA = "0x1835E9550")]
	private void MHCJGCEGAGA(THandle CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x35E9780", Offset = "0x35E8B80", VA = "0x1835E9780")]
	private void OBJMIPKFKNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface IKDLAGIDJHG
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int JNPBIMHEMIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int OABDMKOGJHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface JNPHCKODDEF<T> : IKDLAGIDJHG, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class JJPMCFHNJFA
{
	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1652BE0", Offset = "0x1651FE0", VA = "0x181652BE0")]
	public static bool CJOMKMAANDC<T>(this T CKELBFAAOKG, T FJLHJLAMLMA) where T : struct, IKDLAGIDJHG
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x2956F20", Offset = "0x2956320", VA = "0x182956F20")]
	public static bool NFDBEOJPGBB<T>(this T CKELBFAAOKG) where T : struct, IKDLAGIDJHG
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6467630", Offset = "0x6466A30", VA = "0x186467630")]
	public static string HMKPBBAGFCP(this IKDLAGIDJHG CKELBFAAOKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class GAFOJCJLCND
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private enum IPOMKDNCHGA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private int FCNILJEDKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private bool CAIBOBOOGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private IPOMKDNCHGA LGKAKPIGKKN;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool AEEILNKOPJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x6465890", Offset = "0x6464C90", VA = "0x186465890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool JIBCMBJANMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x6465060", Offset = "0x6464460", VA = "0x186465060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x6465ED0", Offset = "0x64652D0", VA = "0x186465ED0")]
	public GAFOJCJLCND(bool CAIBOBOOGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x64651F0", Offset = "0x64645F0", VA = "0x1864651F0")]
	public void ICKKGAJEMIA(object JGHFLANLLNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6465DF0", Offset = "0x64651F0", VA = "0x186465DF0")]
	public void PMEJJIMDEPP(int FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x64651E0", Offset = "0x64645E0", VA = "0x1864651E0")]
	public void HKKFDCLNMMJ(uint NEIJFPKLHNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6465870", Offset = "0x6464C70", VA = "0x186465870")]
	public void KKEKEFFPEAE(bool NDCJGBMCJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6465910", Offset = "0x6464D10", VA = "0x186465910")]
	public void PGBBJBIMHLC(long DDKDIHOPPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x6465E90", Offset = "0x6465290", VA = "0x186465E90")]
	public void PMHIIFKPINO(ulong FKMIGIJFBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x6465170", Offset = "0x6464570", VA = "0x186465170")]
	public void HIHJPMBECDO(string IEMIGHHOOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6465070", Offset = "0x6464470", VA = "0x186465070")]
	public void FABDLEJLHPH(Enum EPPMCIFCHBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6465CC0", Offset = "0x64650C0", VA = "0x186465CC0")]
	public void PGKIFICJKGH(IList JOLFKOMKBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x2DB53A0", Offset = "0x2DB47A0", VA = "0x182DB53A0")]
	public void NJKKNOKKEON<T, U>(Dictionary<T, U> EGCOOEIAPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x6465950", Offset = "0x6464D50", VA = "0x186465950")]
	private void PGINBIDCKAM(IDictionary EGCOOEIAPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6464FE0", Offset = "0x64643E0", VA = "0x186464FE0")]
	public int AKGMHBDACOH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x64658A0", Offset = "0x6464CA0", VA = "0x1864658A0")]
	public short PABGGKKBMAK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x6465050", Offset = "0x6464450", VA = "0x186465050")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6465100", Offset = "0x6464500", VA = "0x186465100")]
	private void FJMKLMEFNAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class NLJEBFCLOAO<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	internal class CJMNNGAAEDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public TNode COBPFFJEBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode CNDFBGEJOLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public HAENFKFAOAI CLPCALJPBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public List<HAENFKFAOAI> GOEBCJFLHLB;

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		public CJMNNGAAEDE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal struct HAENFKFAOAI : IComparable<HAENFKFAOAI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public int KJECNLJKDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public TClaimant JNMOKPIAMID;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x92B460", Offset = "0x92A860", VA = "0x18092B460")]
		public HAENFKFAOAI(int KJECNLJKDOP, TClaimant JNMOKPIAMID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x3F87350", Offset = "0x3F86750", VA = "0x183F87350")]
		public bool BKEPFFEMDMF(in HAENFKFAOAI FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x3F873C0", Offset = "0x3F867C0", VA = "0x183F873C0")]
		public bool NMLLLJNLAMF(in HAENFKFAOAI FJLHJLAMLMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x3F873B0", Offset = "0x3F867B0", VA = "0x183F873B0", Slot = "4")]
		public int CompareTo(HAENFKFAOAI FJLHJLAMLMA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x3F873D0", Offset = "0x3F867D0", VA = "0x183F873D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum MHCKPGFGMGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class HJLMIEFACDF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public global::NLJEBFCLOAO<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x2CC96F0", Offset = "0x2CC8AF0", VA = "0x182CC96F0")]
		[DebuggerHidden]
		public HJLMIEFACDF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x39D45D0", Offset = "0x39D39D0", VA = "0x1839D45D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x39D4790", Offset = "0x39D3B90", VA = "0x1839D4790", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x39D46B0", Offset = "0x39D3AB0", VA = "0x1839D46B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x2525000", Offset = "0x2524400", VA = "0x182525000", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly global::LIGGINAPNEI<CJMNNGAAEDE> MKCFOBACCAL;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly global::LIGGINAPNEI<List<HAENFKFAOAI>> IBCEADDPJDG;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static int IICHPNKHANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	internal readonly Dictionary<TClaimant, TNode> DKCKPKNLMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	internal readonly Dictionary<TNode, CJMNNGAAEDE> OPHOLDDBNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private MHCKPGFGMGF CMBMANJMAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private bool GBMPCBCEGPH;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode CCHAPKECBLI(TNode HLJLMLNJBJM);

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NPGELKOCLMP(TNode HLJLMLNJBJM, TClaimant ODGBKAJFLLG, TClaimant PPGJMKFHAKF);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x3350F80", Offset = "0x3350380", VA = "0x183350F80")]
	public NLJEBFCLOAO(MHCKPGFGMGF CMBMANJMAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x33507C0", Offset = "0x334FBC0", VA = "0x1833507C0")]
	public void HEJDBLEHJEI(TNode HLJLMLNJBJM, TNode HKBAAFCKIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x334FA50", Offset = "0x334EE50", VA = "0x18334FA50")]
	public void DPGIFNDFFME(TClaimant JNMOKPIAMID, TNode KOHOKCLJFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x334FB50", Offset = "0x334EF50", VA = "0x18334FB50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x3350840", Offset = "0x334FC40", VA = "0x183350840")]
	private void HGHHIJOPPBK(TClaimant JNMOKPIAMID, TNode FOJJMMGOIIA, TNode KOHOKCLJFAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x33508E0", Offset = "0x334FCE0", VA = "0x1833508E0")]
	private int HKBEAILNCIG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x3350010", Offset = "0x334F410", VA = "0x183350010")]
	private void EMMPCJEFBNC(TClaimant JNMOKPIAMID, TNode HHCDBDPIHEF, TNode OPNIEJJIALI, int HHONCHABKEA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x33502C0", Offset = "0x334F6C0", VA = "0x1833502C0")]
	private void ENOKOJOAGIE(HAENFKFAOAI GCLJBFKFALA, CJMNNGAAEDE GEAFCDFAEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x334FDB0", Offset = "0x334F1B0", VA = "0x18334FDB0")]
	private void EDOBJADHBPD(TClaimant JNMOKPIAMID, TNode HHCDBDPIHEF, TNode OPNIEJJIALI, int HHONCHABKEA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x334F830", Offset = "0x334EC30", VA = "0x18334F830")]
	private void BKFALHCKNBO(HAENFKFAOAI GCLJBFKFALA, TNode HLJLMLNJBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x3350350", Offset = "0x334F750", VA = "0x183350350")]
	private void FCHMFIKKKKC(HAENFKFAOAI GCLJBFKFALA, CJMNNGAAEDE GEAFCDFAEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x334F940", Offset = "0x334ED40", VA = "0x18334F940")]
	private void DENIINDKBJM(CJMNNGAAEDE GEAFCDFAEKF, bool FEEBCIGDDDE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x3350450", Offset = "0x334F850", VA = "0x183350450")]
	private void GOGJOPCBCAL(CJMNNGAAEDE GEAFCDFAEKF, TNode HKBAAFCKIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x3350940", Offset = "0x334FD40", VA = "0x183350940")]
	[IteratorStateMachine(typeof(global::NLJEBFCLOAO<, >.HJLMIEFACDF))]
	private IEnumerable<TNode> HNEFLKIIDDA(TNode HHCDBDPIHEF, TNode OPNIEJJIALI, bool BCMPBEBBMOM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x3350BD0", Offset = "0x334FFD0", VA = "0x183350BD0")]
	private CJMNNGAAEDE MCFBFBAHFNH(TNode HLJLMLNJBJM, TNode CNDFBGEJOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x3350C90", Offset = "0x3350090", VA = "0x183350C90")]
	private CJMNNGAAEDE MNLLPHLBIEM(TNode HLJLMLNJBJM, TNode CNDFBGEJOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x3350A10", Offset = "0x334FE10", VA = "0x183350A10")]
	private void MBGJJLHHCEF(CJMNNGAAEDE GEAFCDFAEKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class MHPONCPIFDE<T> : IEnumerable<global::MHPONCPIFDE<T>.JCEIGACJMHH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct JCEIGACJMHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public T FPLJCBGEJAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public int GABJOMFFJAI;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class MJIFEKBIMJN : IEnumerator<JCEIGACJMHH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private global::MHPONCPIFDE<T> MJKBPIALMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private int GABJOMFFJAI;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x1F121D0", Offset = "0x1F115D0", VA = "0x181F121D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public JCEIGACJMHH HMAPMKOECOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x3810410", Offset = "0x380F810", VA = "0x183810410", Slot = "4")]
			get
			{
				return default(JCEIGACJMHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x881430", Offset = "0x880830", VA = "0x180881430")]
		public MJIFEKBIMJN(global::MHPONCPIFDE<T> MJKBPIALMBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x3810250", Offset = "0x380F650", VA = "0x183810250", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x881420", Offset = "0x880820", VA = "0x180881420", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1125B80", Offset = "0x1124F80", VA = "0x181125B80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct MJLCBLAGNCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public bool GAPPINGKDJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public T FPLJCBGEJAP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private const int GEDOHHPJKEO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Dictionary<T, int> MBJCCNGEKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private MJLCBLAGNCI[] LAOHENLNIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private int PBHJCCPHKOD;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int KAJBDGBLCJL
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x8D4020", Offset = "0x8D3420", VA = "0x1808D4020")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1F30", Offset = "0x9F1330", VA = "0x1809F1F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x27EABD0", Offset = "0x27E9FD0", VA = "0x1827EABD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x380EA10", Offset = "0x380DE10", VA = "0x18380EA10")]
	public MHPONCPIFDE(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x380EEF0", Offset = "0x380E2F0", VA = "0x18380EEF0")]
	public MHPONCPIFDE(JCEIGACJMHH[] PIKKADCAMCB, bool HEALNPHLFKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x380E300", Offset = "0x380D700", VA = "0x18380E300")]
	public int GBNHCKNCAOF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x380DDE0", Offset = "0x380D1E0", VA = "0x18380DDE0")]
	private int CCKHICCNLLI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x380E440", Offset = "0x380D840", VA = "0x18380E440", Slot = "6")]
	protected virtual uint IKGBPIBLEIK(uint FCNILJEDKDH, T FPLJCBGEJAP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x380E460", Offset = "0x380D860", VA = "0x18380E460")]
	public bool NJENLJADJNM(T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x380E2B0", Offset = "0x380D6B0", VA = "0x18380E2B0")]
	public bool GBFAJNGMJBA(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x380D740", Offset = "0x380CB40", VA = "0x18380D740")]
	public bool AGHBGCOAOGM(Func<T, bool> NGINFEJBBLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x380E030", Offset = "0x380D430", VA = "0x18380E030")]
	public int EBKFFMFHAPB(T FPLJCBGEJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x380E0F0", Offset = "0x380D4F0", VA = "0x18380E0F0")]
	public T ECDBBAKEJAB(int GABJOMFFJAI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x380D8C0", Offset = "0x380CCC0", VA = "0x18380D8C0")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x380E920", Offset = "0x380DD20", VA = "0x18380E920")]
	public bool PPNDICAMACE(T FPLJCBGEJAP, bool MEDGHNHPPFB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x380E520", Offset = "0x380D920", VA = "0x18380E520")]
	public bool PPNDICAMACE(T FPLJCBGEJAP, int GABJOMFFJAI, bool MEDGHNHPPFB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x380E1D0", Offset = "0x380D5D0", VA = "0x18380E1D0")]
	public bool GAMANBAONBG(T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x380E4D0", Offset = "0x380D8D0", VA = "0x18380E4D0")]
	public bool OKDKIIFFNKJ(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x380D650", Offset = "0x380CA50", VA = "0x18380D650")]
	private void ABBPOIMPIKP(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x380DAB0", Offset = "0x380CEB0", VA = "0x18380DAB0")]
	public JCEIGACJMHH[] BJNJCKGMKBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x380E3C0", Offset = "0x380D7C0", VA = "0x18380E3C0")]
	private int GHEOPNHNMGK(int FAOJDGPICDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x380E990", Offset = "0x380DD90", VA = "0x18380E990", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x380E990", Offset = "0x380DD90", VA = "0x18380E990", Slot = "4")]
	private IEnumerator<JCEIGACJMHH> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct NAJOHDHEBPC<Handle> where Handle : IKDLAGIDJHG, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private struct EOHEHCGPMBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly global::NAJOHDHEBPC<Handle> IPIACHABEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private int GABJOMFFJAI;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int BKIHGLBCODL
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x2529F50", Offset = "0x2529350", VA = "0x182529F50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle DCODBMCDMBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x252A550", Offset = "0x2529950", VA = "0x18252A550")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x252ADD0", Offset = "0x252A1D0", VA = "0x18252ADD0")]
		public EOHEHCGPMBB(global::NAJOHDHEBPC<Handle> IPIACHABEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x252A150", Offset = "0x2529550", VA = "0x18252A150")]
		public LEIHMJFGDHO GEGCLDEHDAN(in LEIHMJFGDHO FKBMHFEKLIC)
		{
			return default(LEIHMJFGDHO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x252A1F0", Offset = "0x25295F0", VA = "0x18252A1F0")]
		public OBCBKMNAAEM GEGCLDEHDAN(in OBCBKMNAAEM FKBMHFEKLIC)
		{
			return default(OBCBKMNAAEM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x252AA50", Offset = "0x2529E50", VA = "0x18252AA50")]
		public bool KECFHJNJDGC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x2529CB0", Offset = "0x25290B0", VA = "0x182529CB0")]
		private int EDIMNGIHHGB(string CIBBLLOHCGM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x252ACE0", Offset = "0x252A0E0", VA = "0x18252ACE0")]
		private Handle ONMGPICCKJA(string CIBBLLOHCGM)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct LEIHMJFGDHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private EOHEHCGPMBB EHFDGOHPPGB;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int HMAPMKOECOA
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x2E9C4B0", Offset = "0x2E9B8B0", VA = "0x182E9C4B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F970", Offset = "0x2C0ED70", VA = "0x182C0F970")]
		public LEIHMJFGDHO(global::NAJOHDHEBPC<Handle> IPIACHABEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F930", Offset = "0x2C0ED30", VA = "0x182C0F930")]
		public bool KECFHJNJDGC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x2E9C530", Offset = "0x2E9B930", VA = "0x182E9C530")]
		public LEIHMJFGDHO IINGNKPPFJF()
		{
			return default(LEIHMJFGDHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct OBCBKMNAAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private EOHEHCGPMBB EHFDGOHPPGB;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle HMAPMKOECOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x2C0F770", Offset = "0x2C0EB70", VA = "0x182C0F770")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F970", Offset = "0x2C0ED70", VA = "0x182C0F970")]
		public OBCBKMNAAEM(global::NAJOHDHEBPC<Handle> IPIACHABEKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F930", Offset = "0x2C0ED30", VA = "0x182C0F930")]
		public bool KECFHJNJDGC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x2C0F7F0", Offset = "0x2C0EBF0", VA = "0x182C0F7F0")]
		public OBCBKMNAAEM IINGNKPPFJF()
		{
			return default(OBCBKMNAAEM);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private NativeList<int> IBMKEFOPEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private NativeList<int> KNGIKMACCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private int ANPBAJBBOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int KHIFJJENGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private bool FMBHFIMKIJI;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool OGKFMAGAFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x8A81C0", Offset = "0x8A75C0", VA = "0x1808A81C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int LPHNGEMLJIO
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x362BF60", Offset = "0x362B360", VA = "0x18362BF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int ODAFDCFKKIG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x764360", Offset = "0x763760", VA = "0x180764360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int CPBOJNDMEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x764360", Offset = "0x763760", VA = "0x180764360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public LEIHMJFGDHO DGEDKMKHCOP
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x362B900", Offset = "0x362AD00", VA = "0x18362B900")]
		get
		{
			return default(LEIHMJFGDHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public OBCBKMNAAEM CMIKCLHLMBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x362EA40", Offset = "0x362DE40", VA = "0x18362EA40")]
		get
		{
			return default(OBCBKMNAAEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x362F360", Offset = "0x362E760", VA = "0x18362F360")]
	public NAJOHDHEBPC(int CMFFFGBOHFO, Allocator NDJJBKEIGCD = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x362CC30", Offset = "0x362C030", VA = "0x18362CC30")]
	public void IDPLHJEPBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x20CA8A0", Offset = "0x20C9CA0", VA = "0x1820CA8A0")]
	public static int KAKMOJDENKI(int OLMDMLKDJGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x362DCF0", Offset = "0x362D0F0", VA = "0x18362DCF0")]
	public static bool LGPGLDMILIL(int OLMDMLKDJGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x362CC20", Offset = "0x362C020", VA = "0x18362CC20")]
	public static bool HOMJLFJMJJG(int OLMDMLKDJGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x362E4E0", Offset = "0x362D8E0", VA = "0x18362E4E0")]
	public bool LPNMMCBLGFK(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x362DF40", Offset = "0x362D340", VA = "0x18362DF40")]
	public bool LPFPOHAMFIL(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x362B5D0", Offset = "0x362A9D0", VA = "0x18362B5D0")]
	public bool BDLBDJMPEAI(Handle CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x362C300", Offset = "0x362B700", VA = "0x18362C300")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void HMFNDLKHFHF(Handle CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x362BC70", Offset = "0x362B070", VA = "0x18362BC70")]
	public Handle EPGOMFDNMPN()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x362D3C0", Offset = "0x362C7C0", VA = "0x18362D3C0")]
	public void KIDMENKOPKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x362BAA0", Offset = "0x362AEA0", VA = "0x18362BAA0")]
	public void BPEPBDIPPKL(Handle CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x362F0A0", Offset = "0x362E4A0", VA = "0x18362F0A0")]
	public bool OBGBHGMAHFL(Handle CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8A81C0", Offset = "0x8A75C0", VA = "0x1808A81C0")]
	private bool LLEKCHHDDPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x362E6C0", Offset = "0x362DAC0", VA = "0x18362E6C0")]
	private bool MAIHABMGIIP(int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x362EAE0", Offset = "0x362DEE0", VA = "0x18362EAE0")]
	private void OBEGEJFNNIA(out int GABJOMFFJAI, out int IIMAMIPIKFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x362AEA0", Offset = "0x362A2A0", VA = "0x18362AEA0")]
	private void AJGFEPEICNA(Handle CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x362B300", Offset = "0x362A700", VA = "0x18362B300")]
	private void BBPHAOGKEFB(int GABJOMFFJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x362E8E0", Offset = "0x362DCE0", VA = "0x18362E8E0")]
	private bool MOGEBLLAPJM(out int GABJOMFFJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x362CF30", Offset = "0x362C330", VA = "0x18362CF30")]
	private static Handle IOBCJIDCOJD(int GABJOMFFJAI, int IIMAMIPIKFH)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[DefaultMember("Item")]
public struct OGHFMFGNANG<Handle, T> where Handle : IKDLAGIDJHG, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private global::NAJOHDHEBPC<Handle> FPNEABLAGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private T[] JOIMPIJIEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Action<T> HHOKGLBNHEG;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool OGKFMAGAFDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x2CBBD20", Offset = "0x2CBB120", VA = "0x182CBBD20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int LPHNGEMLJIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCC90", Offset = "0x2CBC090", VA = "0x182CBCC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC560", Offset = "0x2CBB960", VA = "0x182CBC560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T CLGONNHLFJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x2CBBCC0", Offset = "0x2CBB0C0", VA = "0x182CBBCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x2CBE470", Offset = "0x2CBD870", VA = "0x182CBE470")]
	public OGHFMFGNANG(int CMFFFGBOHFO, [Optional] Action<T> HHOKGLBNHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCD50", Offset = "0x2CBC150", VA = "0x182CBCD50")]
	public void IDPLHJEPBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x2CBB3D0", Offset = "0x2CBA7D0", VA = "0x182CBB3D0")]
	public bool BDLBDJMPEAI(Handle CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void HMFNDLKHFHF(Handle CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x2CBE3B0", Offset = "0x2CBD7B0", VA = "0x182CBE3B0")]
	public T PEBNPJONHNJ(Handle CKELBFAAOKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x2CBCF90", Offset = "0x2CBC390", VA = "0x182CBCF90")]
	public bool KNEMJPBHGAN(Handle CKELBFAAOKG, out T JGHFLANLLNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC180", Offset = "0x2CBB580", VA = "0x182CBC180")]
	public void CODPHMBGNGD(Handle CKELBFAAOKG, T LEOHBMAIAEM, out T GBLEGABPMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC220", Offset = "0x2CBB620", VA = "0x182CBC220")]
	public void CODPHMBGNGD(Handle CKELBFAAOKG, T LEOHBMAIAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2CBB940", Offset = "0x2CBAD40", VA = "0x182CBB940")]
	public bool BEFBJOMBIMM(Handle CKELBFAAOKG, T LEOHBMAIAEM, out T GBLEGABPMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x2CBB860", Offset = "0x2CBAC60", VA = "0x182CBB860")]
	public bool BEFBJOMBIMM(Handle CKELBFAAOKG, T LEOHBMAIAEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC080", Offset = "0x2CBB480", VA = "0x182CBC080")]
	public Handle BKCAAEBNAMB(T JGHFLANLLNE)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD7B0", Offset = "0x2CBCBB0", VA = "0x182CBD7B0")]
	public void OFKADAKIPPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC840", Offset = "0x2CBBC40", VA = "0x182CBC840")]
	public void GAMANBAONBG(Handle CKELBFAAOKG, out T GBLEGABPMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x2CBC6A0", Offset = "0x2CBBAA0", VA = "0x182CBC6A0")]
	public void GAMANBAONBG(Handle CKELBFAAOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x2CBE270", Offset = "0x2CBD670", VA = "0x182CBE270")]
	public bool OIMPFJJEACM(Handle CKELBFAAOKG, out T GBLEGABPMBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x2CBDE10", Offset = "0x2CBD210", VA = "0x182CBDE10")]
	public bool OIMPFJJEACM(Handle CKELBFAAOKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x2CBE350", Offset = "0x2CBD750", VA = "0x182CBE350")]
	private T OKDKIIFFNKJ(int GABJOMFFJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x2CBD280", Offset = "0x2CBC680", VA = "0x182CBD280")]
	private void NAGBAKDBAJB(int HEMIKHAAFPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class LIGGINAPNEI<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Stack<T> IPIACHABEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly List<T> GKEFOCLOJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly int FFBHKJKCLDM;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int CLBOCCIHEBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x252B2A0", Offset = "0x252A6A0", VA = "0x18252B2A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int DNBEFFCOKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x27EABA0", Offset = "0x27E9FA0", VA = "0x1827EABA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2BE0", Offset = "0x2EA1FE0", VA = "0x182EA2BE0")]
	public static global::LIGGINAPNEI<T> EDMPNFGKICE(int NANBMPFBPOK = 0, int FFBHKJKCLDM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2A20", Offset = "0x2EA1E20", VA = "0x182EA2A20")]
	public static global::LIGGINAPNEI<T> BBPLBLJFMDK(int NANBMPFBPOK = 0, int FFBHKJKCLDM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3180", Offset = "0x2EA2580", VA = "0x182EA3180")]
	public LIGGINAPNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x2EA31C0", Offset = "0x2EA25C0", VA = "0x182EA31C0")]
	public LIGGINAPNEI(int NANBMPFBPOK, int FFBHKJKCLDM = int.MaxValue, bool EJCFECCBLCE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2FF0", Offset = "0x2EA23F0", VA = "0x182EA2FF0")]
	public T OIAJFANIEHH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2D80", Offset = "0x2EA2180", VA = "0x182EA2D80")]
	public void HDEHBJFBHLK(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2CB0", Offset = "0x2EA20B0", VA = "0x182EA2CB0")]
	private void FBBNJPHBMNB(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2FD0", Offset = "0x2EA23D0", VA = "0x182EA2FD0")]
	private void MKDNOIENBJA(T FPLJCBGEJAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x2EA3100", Offset = "0x2EA2500", VA = "0x182EA3100")]
	[Conditional("DEBUG_BUILD")]
	private void OPBAIEJMEMO(T AMPKBKDAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2990", Offset = "0x2EA1D90", VA = "0x182EA2990")]
	[Conditional("DEBUG_BUILD")]
	private void AOIPOPJIGKP(T AMPKBKDAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2AF0", Offset = "0x2EA1EF0", VA = "0x182EA2AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x2EA2E30", Offset = "0x2EA2230", VA = "0x182EA2E30")]
	private void KDGHDLDMHIP(IEnumerable<T> LFCHDKPFGIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class MBBADBJJJNF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private Dictionary<int, T> BGPLNFFEOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private T FNCPKCMNDBA;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T KAPIMHALOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x751E00", Offset = "0x751200", VA = "0x180751E00", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x77DF40", Offset = "0x77D340", VA = "0x18077DF40", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool KNEFDNGCGOH
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x3E5C700", Offset = "0x3E5BB00", VA = "0x183E5C700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x3E5C8E0", Offset = "0x3E5BCE0", VA = "0x183E5C8E0")]
	public bool KLKEPONKDMN(T FPLJCBGEJAP, int KJECNLJKDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3E5C9A0", Offset = "0x3E5BDA0", VA = "0x183E5C9A0")]
	public bool MHFEDDGBMKF(int KJECNLJKDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CC30", Offset = "0x3E5C030", VA = "0x183E5CC30")]
	public T NAGHINPLPBP(int CMEPAHHKKDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x3E5C6A0", Offset = "0x3E5BAA0", VA = "0x183E5C6A0")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3E5C740", Offset = "0x3E5BB40", VA = "0x183E5C740")]
	private bool HMJNPLIJBLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CA00", Offset = "0x3E5BE00", VA = "0x183E5CA00")]
	public bool MPHIBFICBKB(int KJECNLJKDOP, out T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3E5CE20", Offset = "0x3E5C220", VA = "0x183E5CE20")]
	public MBBADBJJJNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class HPGKHALMBKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	protected struct MPEKBBMEJOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public T EJBPMDLBLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int ACCGCOJNIMC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected readonly List<MPEKBBMEJOK> BHDEFDFAKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private T FKINENJDJFJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x27EABD0", Offset = "0x27E9FD0", VA = "0x1827EABD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x41ACC20", Offset = "0x41AC020", VA = "0x1841ACC20")]
	public bool AGHBGCOAOGM(T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x41ACE90", Offset = "0x41AC290", VA = "0x1841ACE90")]
	public void BKCAAEBNAMB(T FPLJCBGEJAP, int KJECNLJKDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x41AD010", Offset = "0x41AC410", VA = "0x1841AD010")]
	public bool GAMANBAONBG(T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x41ACE30", Offset = "0x41AC230", VA = "0x1841ACE30")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x41ACFA0", Offset = "0x41AC3A0", VA = "0x1841ACFA0")]
	public T EOBODLKGBNH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x41ACF30", Offset = "0x41AC330", VA = "0x1841ACF30")]
	public T CMCEJPJLBCF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x41AD130", Offset = "0x41AC530", VA = "0x1841AD130")]
	private void NCLPLCKFFMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x41AD2F0", Offset = "0x41AC6F0", VA = "0x1841AD2F0")]
	public HPGKHALMBKC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		[IDDCODEHLBF(HLAHMBHIFJM.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x646A970", Offset = "0x6469D70", VA = "0x18646A970")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x646AD00", Offset = "0x646A100", VA = "0x18646AD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x646AB80", Offset = "0x6469F80", VA = "0x18646AB80")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x646AE60", Offset = "0x646A260", VA = "0x18646AE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x646A890", Offset = "0x6469C90", VA = "0x18646A890")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x646AC20", Offset = "0x646A020", VA = "0x18646AC20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x646AAA0", Offset = "0x6469EA0", VA = "0x18646AAA0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x646A840", Offset = "0x6469C40", VA = "0x18646A840")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface JLAFNJBFIFP
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class ResourcePrefabReference<T> : JLAFNJBFIFP where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x3170560", Offset = "0x316F960", VA = "0x183170560", Slot = "4")]
		public virtual T CBMMFDEBAEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1F13E30", Offset = "0x1F13230", VA = "0x181F13E30")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class DGHEECJFCFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly Dictionary<byte, IMAOBFJEJDI> GPGHHDCFOFN;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IMAOBFJEJDI CEHAOLBEPEO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x705B90", Offset = "0x704F90", VA = "0x180705B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x773890", Offset = "0x772C90", VA = "0x180773890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 JKCNDKFIMON
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xB06740", Offset = "0xB05B40", VA = "0x180B06740")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x751D70", Offset = "0x751170", VA = "0x180751D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 CAPKMPIMAMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x100FA90", Offset = "0x100EE90", VA = "0x18100FA90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x77DED0", Offset = "0x77D2D0", VA = "0x18077DED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 PBKLDKFJMHE
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x6463C00", Offset = "0x6463000", VA = "0x186463C00")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7776B0", Offset = "0x776AB0", VA = "0x1807776B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int FJIGNCNCLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x87D5D0", Offset = "0x87C9D0", VA = "0x18087D5D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x9A5810", Offset = "0x9A4C10", VA = "0x1809A5810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x6463D80", Offset = "0x6463180", VA = "0x186463D80")]
	public DGHEECJFCFD(Bounds KJFBCNKPJFC, Vector2[] JNMFMAJCKBF, int IBLGOEHBPIA, byte FAOJDGPICDF, float GBMICBHNJEN = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6463680", Offset = "0x6462A80", VA = "0x186463680")]
	public IMAOBFJEJDI BNFMGPKPJBL(byte GABJOMFFJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x6463B00", Offset = "0x6462F00", VA = "0x186463B00")]
	public void KLJBHGBDLHK(Vector3 KGJPEGOHADA, float AFEFGKIDADP, float JJGOBPHBIFI, ref List<byte> ILKHGHFGKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6463AE0", Offset = "0x6462EE0", VA = "0x186463AE0")]
	public void GJLPDLKKGDN(IMAOBFJEJDI.MIDHGCAANHK ELNJBLDNGAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6463C20", Offset = "0x6463020", VA = "0x186463C20")]
	private IMAOBFJEJDI PLFPAKNPOMG(byte GABJOMFFJAI, IMAOBFJEJDI.GGGNNBOKIKB EGPGBDOCOMP, IMAOBFJEJDI CNDFBGEJOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x64636E0", Offset = "0x6462AE0", VA = "0x1864636E0")]
	private void DHCPCGCEJGH(IMAOBFJEJDI CNDFBGEJOLI, Vector2[] JNMFMAJCKBF, int EBBMHPFJIHD, int LAJDPMANLKO, int HPKIILPDMPE, int PAFBILLFFHL, float GBMICBHNJEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class IMAOBFJEJDI
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum GGGNNBOKIKB
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum MIDHGCAANHK
	{
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public byte HIIJFIFGFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public Vector3 BJIHPPJKLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 NEINKDNDOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 FAICNJGEGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public Vector3 BCJKGKFAKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public GGGNNBOKIKB BOCFELLJBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public IMAOBFJEJDI DOOCCGCNAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public List<IMAOBFJEJDI> NJIHCGCADND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public bool ALHCBBJPBID;

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6467610", Offset = "0x6466A10", VA = "0x186467610")]
	public IMAOBFJEJDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x64675B0", Offset = "0x64669B0", VA = "0x1864675B0")]
	public IMAOBFJEJDI(byte BJKMNBIBKCI, GGGNNBOKIKB EGPGBDOCOMP, IMAOBFJEJDI CNDFBGEJOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x64674B0", Offset = "0x64668B0", VA = "0x1864674B0")]
	public void OFOBOCNNGKJ(IMAOBFJEJDI NEICBHGNPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public void GJLPDLKKGDN(int ADKACHGFACP, MIDHGCAANHK ELNJBLDNGAH, int NMICCOHLEHA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6467200", Offset = "0x6466600", VA = "0x186467200")]
	public void KLJBHGBDLHK(List<byte> ILKHGHFGKLH, Vector3 KGJPEGOHADA, float AFEFGKIDADP, float JJGOBPHBIFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x64671B0", Offset = "0x64665B0", VA = "0x1864671B0")]
	public bool JLEKHEFFNDK(Vector3 MAPPOODMLLL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6467570", Offset = "0x6466970", VA = "0x186467570")]
	public bool OHGMOLFMJEO(Vector3 MAPPOODMLLL, float NJECDOOILJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class NMFDGDGIFJI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly Dictionary<T, object> BEPBPHJBOHF;

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x2B3E610", Offset = "0x2B3DA10", VA = "0x182B3E610")]
	public bool FMGGPMOMFAB(T MIACEMALNDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3353310", Offset = "0x3352710", VA = "0x183353310")]
	public bool FMGGPMOMFAB(T MIACEMALNDM, object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3353350", Offset = "0x3352750", VA = "0x183353350")]
	public bool FMGGPMOMFAB(T MIACEMALNDM, object JCHAGIDHJIB, out object IEGHFCOHIKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3353550", Offset = "0x3352950", VA = "0x183353550")]
	public bool KDBAGMBNFMM(T MIACEMALNDM, object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x33533B0", Offset = "0x33527B0", VA = "0x1833533B0")]
	public bool GCEEPHLOEAM(T MIACEMALNDM, object JCHAGIDHJIB, out object IEGHFCOHIKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x33534C0", Offset = "0x33528C0", VA = "0x1833534C0")]
	public bool KDBAGMBNFMM(T MIACEMALNDM, object JCHAGIDHJIB, out object IEGHFCOHIKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x3353490", Offset = "0x3352890", VA = "0x183353490")]
	public void JGJLOJOPCFE(T MIACEMALNDM, object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x33533F0", Offset = "0x33527F0", VA = "0x1833533F0")]
	public void HCOLDDDGIPO(T MIACEMALNDM, object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3353590", Offset = "0x3352990", VA = "0x183353590")]
	public NMFDGDGIFJI()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		public struct AIHKOELNLOD<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			private readonly List<Component> JOLFKOMKBCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly bool CAAEGEBDBPC;

			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xE8AA30", Offset = "0xE89E30", VA = "0x180E8AA30")]
			public AIHKOELNLOD(List<Component> JOLFKOMKBCI, bool CAAEGEBDBPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x3228F10", Offset = "0x3228310", VA = "0x183228F10")]
			public EKCHBPLCNKM<T> IINGNKPPFJF()
			{
				return default(EKCHBPLCNKM<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x3228F80", Offset = "0x3228380", VA = "0x183228F80", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x3228F80", Offset = "0x3228380", VA = "0x183228F80", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		public struct EKCHBPLCNKM<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly List<Component> JOLFKOMKBCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private readonly bool CAAEGEBDBPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private int GABJOMFFJAI;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T HMAPMKOECOA
			{
				[Cpp2IlInjected.Token(Token = "0x60003E9")]
				[Cpp2IlInjected.Address(RVA = "0x3B3B3B0", Offset = "0x3B3A7B0", VA = "0x183B3B3B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x3B3B340", Offset = "0x3B3A740", VA = "0x183B3B340", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x3B3B380", Offset = "0x3B3A780", VA = "0x183B3B380")]
			public EKCHBPLCNKM(List<Component> JOLFKOMKBCI, bool CAAEGEBDBPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x3B3B280", Offset = "0x3B3A680", VA = "0x183B3B280", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x3B3B290", Offset = "0x3B3A690", VA = "0x183B3B290", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x31D46A0", Offset = "0x31D3AA0", VA = "0x1831D46A0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x646CB30", Offset = "0x646BF30", VA = "0x18646CB30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x646CAF0", Offset = "0x646BEF0", VA = "0x18646CAF0")]
		public ToolHierarchyCache(GameObject EBOMDGJFPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x646C460", Offset = "0x646B860", VA = "0x18646C460")]
		private void NPFGFFCDMGH(GameObject EBOMDGJFPAB, bool MGJBBFOJNFN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x646C5C0", Offset = "0x646B9C0", VA = "0x18646C5C0")]
		public static void NPFGFFCDMGH(GameObject EBOMDGJFPAB, ref ToolHierarchyCache KMIGLIJPMNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x646C3D0", Offset = "0x646B7D0", VA = "0x18646C3D0")]
		public void FIFCDDDBKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x646C280", Offset = "0x646B680", VA = "0x18646C280")]
		public void DDCJLJCMBJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x318AD30", Offset = "0x318A130", VA = "0x18318AD30")]
		public void HJMKDIOCKHI<T>(Action<T> EFFJGLADCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x646C9A0", Offset = "0x646BDA0", VA = "0x18646C9A0")]
		public Component PCACJDKLHJN(Type BKGBGEHNCAE, bool CAAEGEBDBPC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x318AFC0", Offset = "0x318A3C0", VA = "0x18318AFC0")]
		public T PCACJDKLHJN<T>(bool CAAEGEBDBPC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x646C2D0", Offset = "0x646B6D0", VA = "0x18646C2D0")]
		public AIHKOELNLOD<Component> EJBFCNILFJC(Type BKGBGEHNCAE, bool CAAEGEBDBPC = false)
		{
			return default(AIHKOELNLOD<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x318AC60", Offset = "0x318A060", VA = "0x18318AC60")]
		public AIHKOELNLOD<T> EJBFCNILFJC<T>(bool CAAEGEBDBPC = false) where T : class
		{
			return default(AIHKOELNLOD<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x646C650", Offset = "0x646BA50", VA = "0x18646C650")]
		public List<Component> ONNLIDBDIPL(Type BKGBGEHNCAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x646C350", Offset = "0x646B750", VA = "0x18646C350", Slot = "4")]
		public bool Equals(ToolHierarchyCache IMDGNLLHHDC, ToolHierarchyCache NJNDPGIDOBC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x646C3E0", Offset = "0x646B7E0", VA = "0x18646C3E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache JGHFLANLLNE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class HACIMAGCCNO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private int NANBMPFBPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private int HDGNCGINBKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<T> INJMMDAENFI;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x252B2A0", Offset = "0x252A6A0", VA = "0x18252B2A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T DPHLGAHHPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x3F87090", Offset = "0x3F86490", VA = "0x183F87090")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T IIGNNGEMFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x3F87160", Offset = "0x3F86560", VA = "0x183F87160")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T FMBGEMICOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x3F87210", Offset = "0x3F86610", VA = "0x183F87210")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x3F87270", Offset = "0x3F86670", VA = "0x183F87270")]
	public HACIMAGCCNO(int NANBMPFBPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x3F86D60", Offset = "0x3F86160", VA = "0x183F86D60")]
	public void BKCAAEBNAMB(T LPHOMMCLDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x3F86D20", Offset = "0x3F86120", VA = "0x183F86D20")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x3F86F70", Offset = "0x3F86370", VA = "0x183F86F70")]
	public void EEGFBOIOCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x3F86F20", Offset = "0x3F86320", VA = "0x183F86F20")]
	public void EAHANEMIFFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x3F86F10", Offset = "0x3F86310", VA = "0x183F86F10")]
	public void CEMOOCMFLHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class LLABOCJPLFP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private bool EBPGNFJHCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private Action EFFJGLADCMH;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static LLABOCJPLFP BPCIPEGOJJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x6467AB0", Offset = "0x6466EB0", VA = "0x186467AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool OLDBAIALENE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x826290", Offset = "0x825690", VA = "0x180826290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0x14CED70", Offset = "0x14CE170", VA = "0x1814CED70")]
	public LLABOCJPLFP(Action EFFJGLADCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0x6467A90", Offset = "0x6466E90", VA = "0x186467A90")]
	public void ENDFAGEBOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x6467A90", Offset = "0x6466E90", VA = "0x186467A90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class HPGJOCJNPDH
{
	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x6466FA0", Offset = "0x64663A0", VA = "0x186466FA0")]
	public static void OMABMPDFMJG(DIIDNNFFODO CAMCOAGECDC, string NNLICFIEDDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F7A40", Offset = "0x6F6E40", VA = "0x1806F7A40")]
	public static void OMABMPDFMJG(IEnumerable<object> ADKIJCPOMNK, string NNLICFIEDDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class EPNBIHELPCL<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private struct FBOAJPFDNDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int ACCGCOJNIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public T EJBPMDLBLGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private readonly Dictionary<object, FBOAJPFDNDE> BGPLNFFEOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly EqualityComparer<T> KLDMLMBGGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private T FNCPKCMNDBA;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T KAPIMHALOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x81B480", Offset = "0x81A880", VA = "0x18081B480", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x81B680", Offset = "0x81AA80", VA = "0x18081B680", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool KNEFDNGCGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x2530A70", Offset = "0x252FE70", VA = "0x182530A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object DPFFDDPLIJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x81B670", Offset = "0x81AA70", VA = "0x18081B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x2534C90", Offset = "0x2534090", VA = "0x182534C90")]
	public bool KLKEPONKDMN(T FPLJCBGEJAP, object JCHAGIDHJIB, int KJECNLJKDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x2535400", Offset = "0x2534800", VA = "0x182535400")]
	public bool MHFEDDGBMKF(object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x2535690", Offset = "0x2534A90", VA = "0x182535690")]
	public bool MPHIBFICBKB(object JCHAGIDHJIB, out T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x2530A40", Offset = "0x252FE40", VA = "0x182530A40")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x2533120", Offset = "0x2532520", VA = "0x182533120")]
	private bool HMJNPLIJBLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x2535AB0", Offset = "0x2534EB0", VA = "0x182535AB0")]
	public EPNBIHELPCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class GIMNKJFKOMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private Dictionary<object, float> BGPLNFFEOHL;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float KPJEBJGGFFH
	{
		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x85BD40", Offset = "0x85B140", VA = "0x18085BD40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x859A50", Offset = "0x858E50", VA = "0x180859A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x6466160", Offset = "0x6465560", VA = "0x186466160")]
	public void KLKEPONKDMN(float FPLJCBGEJAP, object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x64661D0", Offset = "0x64655D0", VA = "0x1864661D0")]
	public void MHFEDDGBMKF(object JCHAGIDHJIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x6466040", Offset = "0x6465440", VA = "0x186466040")]
	private void AKOPOIMFOIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6466240", Offset = "0x6465640", VA = "0x186466240")]
	public GIMNKJFKOMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class ANOHCNMGJIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public readonly string OKNDBJNBMJG;

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x75F090", Offset = "0x75E490", VA = "0x18075F090")]
	public ANOHCNMGJIP(string IMCPADIIPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x6463280", Offset = "0x6462680", VA = "0x186463280")]
	public ANOHCNMGJIP(UnityEngine.Object MOCKCIDHGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6463230", Offset = "0x6462630", VA = "0x186463230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class DIIDNNFFODO
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class EIIDMKJGOOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public EIIDMKJGOOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6464770", Offset = "0x6463B70", VA = "0x186464770")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private HashSet<object> ADKIJCPOMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private int BBDLJMDMGKF;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> GJGGGEBIAIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x6464450", Offset = "0x6463850", VA = "0x186464450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool JPHLGBLIGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6464440", Offset = "0x6463840", VA = "0x186464440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int HMGCLIBMMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x705BA0", Offset = "0x704FA0", VA = "0x180705BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x64642B0", Offset = "0x64636B0", VA = "0x1864642B0")]
	public bool BKCAAEBNAMB(object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x64643A0", Offset = "0x64637A0", VA = "0x1864643A0")]
	public bool GAMANBAONBG(object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x64641E0", Offset = "0x64635E0", VA = "0x1864641E0")]
	public bool AGHBGCOAOGM(object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x6464240", Offset = "0x6463640", VA = "0x186464240")]
	public void ALKIJCIDMJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x6464520", Offset = "0x6463920", VA = "0x186464520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public DIIDNNFFODO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class ILLCLDGOCBE<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct EGMIMAFAFOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public float MILECAFIBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public T EJBPMDLBLGL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Dictionary<object, EGMIMAFAFOK> BGPLNFFEOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private T DEBPFGOBNFC;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T CIJJGNHEPHH
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x1A248F0", Offset = "0x1A23CF0", VA = "0x181A248F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x2275050", Offset = "0x2274450", VA = "0x182275050", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object IOBOJJNGDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x6C6320", Offset = "0x6C5720", VA = "0x1806C6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x81B670", Offset = "0x81AA70", VA = "0x18081B670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool KNEFDNGCGOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x33B88D0", Offset = "0x33B7CD0", VA = "0x1833B88D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x33BA360", Offset = "0x33B9760", VA = "0x1833BA360")]
	public bool KLKEPONKDMN(T FPLJCBGEJAP, object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x33BA540", Offset = "0x33B9940", VA = "0x1833BA540")]
	public bool MHFEDDGBMKF(object JCHAGIDHJIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x2530A40", Offset = "0x252FE40", VA = "0x182530A40")]
	public void BIEFCABEIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x33BA5A0", Offset = "0x33B99A0", VA = "0x1833BA5A0")]
	public bool MPHIBFICBKB(object JCHAGIDHJIB, out T FPLJCBGEJAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x33B9280", Offset = "0x33B8680", VA = "0x1833B9280")]
	private bool HMJNPLIJBLK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x33BA810", Offset = "0x33B9C10", VA = "0x1833BA810")]
	public ILLCLDGOCBE()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class ABFMAPAPCGL
{
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static byte[] CFDBFPKMJCL;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static int NBKCFIGJMGE;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int BKBNJMLFPCH;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static BigInteger IHOABMABNGK;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
	public ABFMAPAPCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x6462EC0", Offset = "0x64622C0", VA = "0x186462EC0")]
	private static string OGMGDCCGOFL(byte[] CFEKEMJOJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6462B70", Offset = "0x6461F70", VA = "0x186462B70")]
	public static string DFBBLGFDDMJ(byte[] GJDBLJLIDDI, bool JLJMGNGGBON)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
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
