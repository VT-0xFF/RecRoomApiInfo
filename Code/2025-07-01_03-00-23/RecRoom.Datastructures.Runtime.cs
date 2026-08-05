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
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7F6FF30", Offset = "0x7F6E530", VA = "0x187F6FF30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BCGEMACLLBE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2253320", Offset = "0x2251920", VA = "0x182253320")]
	public BCGEMACLLBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, HGDAOBPFKGG, ACALJOKAGIL, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD2DDD0", Offset = "0xD2C3D0", VA = "0x180D2DDD0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash GOFLPLJKKOO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xC6D2F0", Offset = "0xC6B8F0", VA = "0x180C6D2F0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[ReadOnlyField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7F71200", Offset = "0x7F6F800", VA = "0x187F71200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F711C0", Offset = "0x7F6F7C0", VA = "0x187F711C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F71240", Offset = "0x7F6F840", VA = "0x187F71240")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F713F0", Offset = "0x7F6F9F0", VA = "0x187F713F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F71360", Offset = "0x7F6F960", VA = "0x187F71360")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAA7CA0", Offset = "0xAA62A0", VA = "0x180AA7CA0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAA7C90", Offset = "0xAA6290", VA = "0x180AA7C90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7F71180", Offset = "0x7F6F780", VA = "0x187F71180")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F712D0", Offset = "0x7F6F8D0", VA = "0x187F712D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F70C20", Offset = "0x7F6F220", VA = "0x187F70C20")]
	public void CopyBounds(SavedExtents HOPHFOOKMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F710D0", Offset = "0x7F6F6D0", VA = "0x187F710D0")]
	public void SetLocalSpaceBounds(Bounds IEOKHACGFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x15B6A40", Offset = "0x15B5040", VA = "0x1815B6A40")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F710C0", Offset = "0x7F6F6C0", VA = "0x187F710C0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F70D10", Offset = "0x7F6F310", VA = "0x187F70D10")]
	private void OFNFLNPOMAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F70EC0", Offset = "0x7F6F4C0", VA = "0x187F70EC0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F705B0", Offset = "0x7F6EBB0", VA = "0x187F705B0")]
	public static void CalculateLocalBoundsFor(GameObject KGMBEOBCDCB, [Out] Bounds IEOKHACGFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7F70C50", Offset = "0x7F6F250", VA = "0x187F70C50")]
	private static void FADHMKLHOGB(Bounds OKKFDNDPGLP, Color HJGAGGHDFHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F710F0", Offset = "0x7F6F6F0", VA = "0x187F710F0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA44180", Offset = "0xA42780", VA = "0x180A44180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA45180", Offset = "0xA43780", VA = "0x180A45180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1A8E4C0", Offset = "0x1A8CAC0", VA = "0x181A8E4C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5B0B630", Offset = "0x5B09C30", VA = "0x185B0B630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public virtual void OBKJHPNJODD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[BCGEMACLLBE]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B210", Offset = "0x5B09810", VA = "0x185B0B210", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5B09F00", Offset = "0x5B08500", VA = "0x185B09F00", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5B0B580", Offset = "0x5B09B80", VA = "0x185B0B580")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class CJJAHGCHHFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public CJJAHGCHHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x68770A0", Offset = "0x68756A0", VA = "0x1868770A0")]
		internal int EMDDNFKEAIK(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[BCGEMACLLBE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x47A1860", Offset = "0x479FE60", VA = "0x1847A1860", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x47A18B0", Offset = "0x479FEB0", VA = "0x1847A18B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x47A1760", Offset = "0x479FD60", VA = "0x1847A1760", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey BLIBAMJKLIA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x47A1800", Offset = "0x479FE00", VA = "0x1847A1800", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x47A1640", Offset = "0x479FC40", VA = "0x1847A1640", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x47A1350", Offset = "0x479F950", VA = "0x1847A1350", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x47A0790", Offset = "0x479ED90", VA = "0x1847A0790", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x47A06C0", Offset = "0x479ECC0", VA = "0x1847A06C0", Slot = "14")]
	protected virtual string DBONEJCGIOD(TKeyVal MNOLBPAADFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x47A0610", Offset = "0x479EC10", VA = "0x1847A0610", Slot = "4")]
	public bool ContainsKey(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x47A1500", Offset = "0x479FB00", VA = "0x1847A1500", Slot = "5")]
	public bool TryGetValue(TKey BLIBAMJKLIA, [Out] TVal KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x47A06F0", Offset = "0x479ECF0", VA = "0x1847A06F0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x47A06F0", Offset = "0x479ECF0", VA = "0x1847A06F0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x47A1550", Offset = "0x479FB50", VA = "0x1847A1550")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4724F50", Offset = "0x4723550", VA = "0x184724F50")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[BCGEMACLLBE]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5B0CE30", Offset = "0x5B0B430", VA = "0x185B0CE30")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5B0C6F0", Offset = "0x5B0ACF0", VA = "0x185B0C6F0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5B0BCE0", Offset = "0x5B0A2E0", VA = "0x185B0BCE0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class HOAIKGEOMIE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct LBFGNOFNKHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T IBMJNNAJGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float FBPGPNOLBIG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int GKEPBBAIPKN = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float GKKBKMEAHCA = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly LBFGNOFNKHO[] DDENONPPKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int BBLOOMBCEKO;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float BANOPBMHPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xCCD5E0", Offset = "0xCCBBE0", VA = "0x180CCD5E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD1E870", Offset = "0xD1CE70", VA = "0x180D1E870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T DIKOLMDCEPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4E27C60", Offset = "0x4E26260", VA = "0x184E27C60")]
	protected HOAIKGEOMIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4E27C80", Offset = "0x4E26280", VA = "0x184E27C80")]
	protected HOAIKGEOMIE(int GPNBMIDFKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4E27B70", Offset = "0x4E26170", VA = "0x184E27B70")]
	public void JDPCENHCAFL(float PHDJLKIIBIL, T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool KCHMKIBMGEE(float NCBLJDEEOCD, float PBIEBEONIHA, [Out] T KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool NPOMBFKJKHL(float NCBLJDEEOCD, float PBIEBEONIHA, [Out] T KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4E279D0", Offset = "0x4E25FD0", VA = "0x184E279D0")]
	public void HHCEOPNNHLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DCBHBNKCNFN : HOAIKGEOMIE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D3F0", Offset = "0x7F6B9F0", VA = "0x187F6D3F0", Slot = "4")]
	public override bool KCHMKIBMGEE(float NCBLJDEEOCD, float PBIEBEONIHA, [Out] Vector3 KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D550", Offset = "0x7F6BB50", VA = "0x187F6D550", Slot = "5")]
	public override bool NPOMBFKJKHL(float NCBLJDEEOCD, float PBIEBEONIHA, [Out] Vector3 KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D690", Offset = "0x7F6BC90", VA = "0x187F6D690")]
	public DCBHBNKCNFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KKINOGJDGCC
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE6C0", Offset = "0x3BDCCC0", VA = "0x183BDE6C0")]
	public static HCBJPMIGAKP<T1, T2> MMBKOMPANAO<T1, T2>(T1 INEBEOEJEAH, T2 GNOKACHFMKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE740", Offset = "0x3BDCD40", VA = "0x183BDE740")]
	public static JIGIBCFDGPA<T1, T2, T3> MMBKOMPANAO<T1, T2, T3>(T1 INEBEOEJEAH, T2 GNOKACHFMKO, T3 FBMACLGPCHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5668250", Offset = "0x5666850", VA = "0x185668250")]
	internal static int PCPKIEEEGGG(int OJHDFICDIOL, int ABOHJDNAKPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7125240", Offset = "0x7123840", VA = "0x187125240")]
	internal static int PCPKIEEEGGG(int OJHDFICDIOL, int ABOHJDNAKPD, int CLDPDBGIJON)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HCBJPMIGAKP<T1, T2> : IComparable<HCBJPMIGAKP<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 KKGJDCFGHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 BMFAHJBOEPD;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4DDB0D0", Offset = "0x4DD96D0", VA = "0x184DDB0D0")]
	public HCBJPMIGAKP(T1 INEBEOEJEAH, T2 GNOKACHFMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4DD9300", Offset = "0x4DD7900", VA = "0x184DD9300", Slot = "4")]
	public int CompareTo(HCBJPMIGAKP<T1, T2> HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4DD9B50", Offset = "0x4DD8150", VA = "0x184DD9B50", Slot = "0")]
	public override bool Equals(object HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4DDA480", Offset = "0x4DD8A80", VA = "0x184DDA480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4DDAD50", Offset = "0x4DD9350", VA = "0x184DDAD50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JIGIBCFDGPA<T1, T2, T3> : IComparable<JIGIBCFDGPA<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 KKGJDCFGHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 BMFAHJBOEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 KGGMHDKBEKN;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x51D5B80", Offset = "0x51D4180", VA = "0x1851D5B80")]
	public JIGIBCFDGPA(T1 INEBEOEJEAH, T2 GNOKACHFMKO, T3 FBMACLGPCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x51D5350", Offset = "0x51D3950", VA = "0x1851D5350", Slot = "4")]
	public int CompareTo(JIGIBCFDGPA<T1, T2, T3> HOPHFOOKMCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x51D55B0", Offset = "0x51D3BB0", VA = "0x1851D55B0", Slot = "0")]
	public override bool Equals(object HOPHFOOKMCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x51D5810", Offset = "0x51D3E10", VA = "0x1851D5810", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x51D59C0", Offset = "0x51D3FC0", VA = "0x1851D59C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve AJJAAEFIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T INNCEMENDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x131A980", Offset = "0x1318F80", VA = "0x18131A980")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T BDHKAPIGCDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCBDE70", Offset = "0xCBC470", VA = "0x180CBDE70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T IBMJNNAJGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CE70", Offset = "0x2D9B470", VA = "0x182D9CE70")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2D9CE60", Offset = "0x2D9B460", VA = "0x182D9CE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GEHLAJOBKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA9FB60", Offset = "0xA9E160", VA = "0x180A9FB60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6B20", Offset = "0x5DC5120", VA = "0x185DC6B20")]
	public T DOAJAFCMKMF(float MMMCFFENLAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5DC6EF0", Offset = "0x5DC54F0", VA = "0x185DC6EF0")]
	public T NGEINFBGBPJ(float MMMCFFENLAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T IPOHCCDGDJN(T IAPIHBICBOE, T FJDIHEBKFED, float MMMCFFENLAH);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DAA0", Offset = "0x7F6C0A0", VA = "0x187F6DAA0", Slot = "4")]
	protected override float IPOHCCDGDJN(float IAPIHBICBOE, float FJDIHEBKFED, float MMMCFFENLAH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DAE0", Offset = "0x7F6C0E0", VA = "0x187F6DAE0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x18F4D30", Offset = "0x18F3330", VA = "0x1818F4D30", Slot = "4")]
	protected override Vector3 IPOHCCDGDJN(Vector3 IAPIHBICBOE, Vector3 FJDIHEBKFED, float MMMCFFENLAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7F72210", Offset = "0x7F70810", VA = "0x187F72210")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D2F0", Offset = "0x7F6B8F0", VA = "0x187F6D2F0", Slot = "4")]
	protected override Color IPOHCCDGDJN(Color IAPIHBICBOE, Color FJDIHEBKFED, float MMMCFFENLAH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D3B0", Offset = "0x7F6B9B0", VA = "0x187F6D3B0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PJFFILPBACM : GMEIMEMACBJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7F70020", Offset = "0x7F6E620", VA = "0x187F70020")]
	public PJFFILPBACM(int BJPLKLLFDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FFB0", Offset = "0x7F6E5B0", VA = "0x187F6FFB0", Slot = "6")]
	protected override uint AMALCFIPABK(uint GOFLPLJKKOO, string KKGBKLFKCPO)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CHILLFCNMIA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable FNIBPMLJKFE;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public CHILLFCNMIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct LCKNPJIJABE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> DOCGPKAMMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int LFKPDJNDOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int HIEHKIONBGH;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x53794D0", Offset = "0x5377AD0", VA = "0x1853794D0")]
	private LCKNPJIJABE(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PDBLIMOJEFP, int ELHFGECJJGH, int FILKDPOEDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x53771E0", Offset = "0x53757E0", VA = "0x1853771E0")]
	public static LCKNPJIJABE<T> BFOPDLPDKBM()
	{
		return default(LCKNPJIJABE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5378090", Offset = "0x5376690", VA = "0x185378090")]
	public (int, int, Task<T>) KNIHNAGJOOO(int HFCJPLHKMHP, [Optional] CancellationToken KMHHNOGHBLL, double BKONJIDKCPP = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x53772E0", Offset = "0x53758E0", VA = "0x1853772E0")]
	public void HCCIMILMHJK(int HFCJPLHKMHP, int FILKDPOEDAI, [In] T HPCDHGHHCOO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class KGNECKAPHNK
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F1E0", Offset = "0x7F6D7E0", VA = "0x187F6F1E0")]
	public static LCKNPJIJABE<DICNEKFFPEP> BFOPDLPDKBM()
	{
		return default(LCKNPJIJABE<DICNEKFFPEP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F230", Offset = "0x7F6D830", VA = "0x187F6F230")]
	public static void HCCIMILMHJK([In] this LCKNPJIJABE<DICNEKFFPEP> PIKMBNLEPPK, int HFCJPLHKMHP, int FILKDPOEDAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class OBGOAGIJEMO<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> NAJDBEHKLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> LPIPPBNJOLN;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x43253A0", Offset = "0x43239A0", VA = "0x1843253A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool KJKCBDBHHDL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> BGEMCKDNFCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4F6B4A0", Offset = "0x4F69AA0", VA = "0x184F6B4A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> NAOPAJFMJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x57A8ED0", Offset = "0x57A74D0", VA = "0x1857A8ED0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x57A8E70", Offset = "0x57A7470", VA = "0x1857A8E70", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x57A8F10", Offset = "0x57A7510", VA = "0x1857A8F10", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x57A8AD0", Offset = "0x57A70D0", VA = "0x1857A8AD0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x57A8650", Offset = "0x57A6C50", VA = "0x1857A8650", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x57A8CF0", Offset = "0x57A72F0", VA = "0x1857A8CF0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x57A8470", Offset = "0x57A6A70", VA = "0x1857A8470", Slot = "9")]
	public void Add(TKey BLIBAMJKLIA, TVal KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x57A8400", Offset = "0x57A6A00", VA = "0x1857A8400", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x57A86B0", Offset = "0x57A6CB0", VA = "0x1857A86B0", Slot = "8")]
	public bool ContainsKey(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x57A8720", Offset = "0x57A6D20", VA = "0x1857A8720", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x57A8C10", Offset = "0x57A7210", VA = "0x1857A8C10", Slot = "10")]
	public bool Remove(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x57A8C40", Offset = "0x57A7240", VA = "0x1857A8C40", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x57A8D40", Offset = "0x57A7340", VA = "0x1857A8D40", Slot = "11")]
	public bool TryGetValue(TKey BLIBAMJKLIA, [Out] TVal KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x57A8900", Offset = "0x57A6F00", VA = "0x1857A8900", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x57A8750", Offset = "0x57A6D50", VA = "0x1857A8750", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DDENONPPKCL, int FKFIMLILJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x57A8BC0", Offset = "0x57A71C0", VA = "0x1857A8BC0")]
	public bool OMCPIMBCGII(TVal BLIBAMJKLIA, [Out] TKey KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x57A8A30", Offset = "0x57A7030", VA = "0x1857A8A30")]
	private void IDADHFAPBBC(TKey BLIBAMJKLIA, TVal FADBOFNILPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x57A8860", Offset = "0x57A6E60", VA = "0x1857A8860")]
	private void GBBAJGONLEP(TKey BLIBAMJKLIA, TVal FADBOFNILPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x57A8570", Offset = "0x57A6B70", VA = "0x1857A8570")]
	private bool BALFHJENLLH(TKey BLIBAMJKLIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x57A8D80", Offset = "0x57A7380", VA = "0x1857A8D80")]
	public OBGOAGIJEMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class DKMIPOBMCOB<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private DKMIPOBMCOB<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x47F7360", Offset = "0x47F5960", VA = "0x1847F7360", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x48052E0", Offset = "0x48038E0", VA = "0x1848052E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x48065A0", Offset = "0x4804BA0", VA = "0x1848065A0")]
		public Enumerator(DKMIPOBMCOB<T> LBNJMEGEAHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4804660", Offset = "0x4802C60", VA = "0x184804660", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4804D50", Offset = "0x4803350", VA = "0x184804D50", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4803940", Offset = "0x4801F40", VA = "0x184803940")]
		private void GGJKMAMMFIA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] GBIHKBDEEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int IGHNHCKLCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int OKAGIFCCMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int PFGEKBLLNEL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B0E0", Offset = "0x6D196E0", VA = "0x186D1B0E0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6D1A2C0", Offset = "0x6D188C0", VA = "0x186D1A2C0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6D17E70", Offset = "0x6D16470", VA = "0x186D17E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B060", Offset = "0x6D19660", VA = "0x186D1B060")]
	public DKMIPOBMCOB(int BJPLKLLFDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A060", Offset = "0x6D18660", VA = "0x186D1A060")]
	public void JDPCENHCAFL(T MMMCFFENLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6D188B0", Offset = "0x6D16EB0", VA = "0x186D188B0")]
	public void HPNNPOFAAPK(IEnumerable<T> EHECCAJFJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6D187E0", Offset = "0x6D16DE0", VA = "0x186D187E0")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6D18800", Offset = "0x6D16E00", VA = "0x186D18800")]
	public void HNGGHJFPJOK(int FOAMCIPOLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AC00", Offset = "0x6D19200", VA = "0x186D1AC00")]
	public void OGANFLEFEJB(T[] DDENONPPKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6D18020", Offset = "0x6D16620", VA = "0x186D18020")]
	public Enumerator DHKFMABLBKB()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AEF0", Offset = "0x6D194F0", VA = "0x186D1AEF0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AEF0", Offset = "0x6D194F0", VA = "0x186D1AEF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6D18290", Offset = "0x6D16890", VA = "0x186D18290")]
	private int HHBLOBEKBKI(int KHMHPNKMLMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6D18150", Offset = "0x6D16750", VA = "0x186D18150")]
	private int ENNMHFICNON(int KHMHPNKMLMD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class LMAGCMKNGEA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> CCAJFPMBDFP(TRequest IPMGANOCOKF, CancellationToken KMHHNOGHBLL);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum CHPBELBEFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class EADIPOKHKBM
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float BDOHCMGEGFP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan JJIHCKLNCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int NAEMCDGABDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CHPBELBEFAJ BANILEDJLHC;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly EADIPOKHKBM JLODNOEBAIE;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float FEPIDAMFNID
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x4750F90", Offset = "0x474F590", VA = "0x184750F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan PGKMFDFHPFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x47510E0", Offset = "0x474F6E0", VA = "0x1847510E0")]
		public EADIPOKHKBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct ENJOPHFIOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest IPMGANOCOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken KMHHNOGHBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> LKFJDAEMBAK;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x479B700", Offset = "0x4799D00", VA = "0x18479B700")]
		public ENJOPHFIOCI(TRequest IPMGANOCOKF, TaskCompletionSource<TResult> LKFJDAEMBAK, CancellationToken KMHHNOGHBLL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct PNPMAFJFDIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public LMAGCMKNGEA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x58FF870", Offset = "0x58FDE70", VA = "0x1858FF870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x5900410", Offset = "0x58FEA10", VA = "0x185900410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct EBDJHJIIBMK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public LMAGCMKNGEA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private ENJOPHFIOCI <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x47561C0", Offset = "0x47547C0", VA = "0x1847561C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x47573A0", Offset = "0x47559A0", VA = "0x1847573A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource FGANLKMNONM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<ENJOPHFIOCI> HPKKFEHADGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly EADIPOKHKBM JDJEINNINOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly CCAJFPMBDFP OLKMGEAHLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task LDAKNNJDCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int MLCPCPNGKGB;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x54304D0", Offset = "0x542EAD0", VA = "0x1854304D0")]
	public LMAGCMKNGEA(CCAJFPMBDFP OLKMGEAHLCG, [Optional] EADIPOKHKBM JDJEINNINOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x542FB90", Offset = "0x542E190", VA = "0x18542FB90")]
	public Task<TResult> PHDDBAGIDGC(TRequest IPMGANOCOKF, CancellationToken KMHHNOGHBLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x542EAC0", Offset = "0x542D0C0", VA = "0x18542EAC0")]
	private void AEGIBPBGCPD(ENJOPHFIOCI JJHPBGENINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x542F020", Offset = "0x542D620", VA = "0x18542F020")]
	[AsyncStateMachine(typeof(LMAGCMKNGEA<, >.PNPMAFJFDIK))]
	private Task IECGFFBBLCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x542F630", Offset = "0x542DC30", VA = "0x18542F630")]
	private ENJOPHFIOCI KFGOAAGIHHJ()
	{
		return default(ENJOPHFIOCI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x542EC90", Offset = "0x542D290", VA = "0x18542EC90")]
	[AsyncStateMachine(typeof(LMAGCMKNGEA<, >.EBDJHJIIBMK))]
	private Task HMOOHNONAPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x542F8C0", Offset = "0x542DEC0", VA = "0x18542F8C0")]
	private void PFHJMEKOADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x542EB60", Offset = "0x542D160", VA = "0x18542EB60", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class CFLLDJIJELA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> BGGFBGFNIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> ONJDOLHJCDP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x43253A0", Offset = "0x43239A0", VA = "0x1843253A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KJKCBDBHHDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T FCKKEJIGIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4E1AAE0", Offset = "0x4E190E0", VA = "0x184E1AAE0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x679B3B0", Offset = "0x67999B0", VA = "0x18679B3B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4CAAFB0", Offset = "0x4CA95B0", VA = "0x184CAAFB0", Slot = "11")]
	public void Add(T GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x679AE10", Offset = "0x6799410", VA = "0x18679AE10")]
	public bool NIKECJDPHKD(T GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x679B220", Offset = "0x6799820", VA = "0x18679B220", Slot = "15")]
	public bool Remove(T GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x679ABC0", Offset = "0x67991C0", VA = "0x18679ABC0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4D03F80", Offset = "0x4D02580", VA = "0x184D03F80", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x679AAF0", Offset = "0x67990F0", VA = "0x18679AAF0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x679AB50", Offset = "0x6799150", VA = "0x18679AB50", Slot = "13")]
	public bool Contains(T GANFJJCKLGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x679AB90", Offset = "0x6799190", VA = "0x18679AB90", Slot = "14")]
	public void CopyTo(T[] DDENONPPKCL, int FKFIMLILJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5346B80", Offset = "0x5345180", VA = "0x185346B80", Slot = "6")]
	public int IndexOf(T GANFJJCKLGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x679AD30", Offset = "0x6799330", VA = "0x18679AD30", Slot = "7")]
	public void Insert(int KHMHPNKMLMD, T GANFJJCKLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x679AF90", Offset = "0x6799590", VA = "0x18679AF90", Slot = "8")]
	public void RemoveAt(int KHMHPNKMLMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x679B2C0", Offset = "0x67998C0", VA = "0x18679B2C0")]
	public CFLLDJIJELA()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2BFD350", Offset = "0x2BFB950", VA = "0x182BFD350")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA9EFF0", Offset = "0xA9D5F0", VA = "0x180A9EFF0")]
		public SerializedGuid([In] Guid PPIICOOCLEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F71590", Offset = "0x7F6FB90", VA = "0x187F71590")]
		public static SerializedGuid ILPNPGAONNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F71610", Offset = "0x7F6FC10", VA = "0x187F71610")]
		public static SerializedGuid KAFJAPNLLCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F71680", Offset = "0x7F6FC80", VA = "0x187F71680")]
		public bool NGPOKKIJIOI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F71760", Offset = "0x7F6FD60", VA = "0x187F71760", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F716E0", Offset = "0x7F6FCE0", VA = "0x187F716E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F714B0", Offset = "0x7F6FAB0", VA = "0x187F714B0", Slot = "7")]
		public bool Equals(SerializedGuid HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F714F0", Offset = "0x7F6FAF0", VA = "0x187F714F0", Slot = "0")]
		public override bool Equals(object ODCICEDDLMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F71580", Offset = "0x7F6FB80", VA = "0x187F71580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F71480", Offset = "0x7F6FA80", VA = "0x187F71480", Slot = "6")]
		public int CompareTo(SerializedGuid HOPHFOOKMCC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HKABGIDGLCO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type IBIAODPCPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string EFCJHAGBOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool GEHPBKDPPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool ADMADGHHOIB;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EDF0", Offset = "0x7F6D3F0", VA = "0x187F6EDF0")]
	public HKABGIDGLCO(Type GLOPKKJDDIP, string JCMBFAPIPOH, bool IEEAEALGIKG = false, bool BNEIJMFJJPD = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MGBDGHLCAFL<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int HLOGIMCLHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> PDPJOCNPGEN(float PHDJLKIIBIL, [Optional] float? BMEAOJPINNK);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HJKCMKGBGGD(float PHDJLKIIBIL, T KKGBKLFKCPO);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HHCEOPNNHLH();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class EGCLOIJHCPH<T> : MGBDGHLCAFL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class AELGEPPHKII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float EDNAKNOMGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T IBMJNNAJGNM;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public AELGEPPHKII()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class DKLEONAHMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DKLEONAHMNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D17CA0", Offset = "0x6D162A0", VA = "0x186D17CA0")]
		internal bool KAIPPPFPJDK(AELGEPPHKII sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float MEPCOGEMGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float JPJPKNBPOKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<AELGEPPHKII> EKCFEOFNIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private CKMEAMFPAKH<AELGEPPHKII> KEDHCGGDGNI;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int HLOGIMCLHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x4782340", Offset = "0x4780940", VA = "0x184782340", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4782F60", Offset = "0x4781560", VA = "0x184782F60")]
	public EGCLOIJHCPH(float HCKIAICAPFL, float HFMCPDFBPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4782490", Offset = "0x4780A90", VA = "0x184782490", Slot = "6")]
	public bool HJKCMKGBGGD(float PHDJLKIIBIL, T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4782C30", Offset = "0x4781230", VA = "0x184782C30", Slot = "5")]
	public IEnumerable<T> PDPJOCNPGEN(float PHDJLKIIBIL, float? BMEAOJPINNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4782420", Offset = "0x4780A20", VA = "0x184782420", Slot = "7")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x47827A0", Offset = "0x4780DA0", VA = "0x1847827A0")]
	private void MEKDMNKFLLF(float PHDJLKIIBIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class JFHJAGCOCBN<T> : MGBDGHLCAFL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct FMOBDAJAFHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T IBMJNNAJGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float EDNAKNOMGMP;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4C58D90", Offset = "0x4C57390", VA = "0x184C58D90")]
		public FMOBDAJAFHG(T KKGBKLFKCPO, float PHDJLKIIBIL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class MKOHLMOHMCG : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public JFHJAGCOCBN<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public MKOHLMOHMCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5613670", Offset = "0x5611C70", VA = "0x185613670", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x56139F0", Offset = "0x5611FF0", VA = "0x1856139F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5613820", Offset = "0x5611E20", VA = "0x185613820", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4D8C900", Offset = "0x4D8AF00", VA = "0x184D8C900", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float HCKIAICAPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float HFMCPDFBPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<FMOBDAJAFHG> EKCFEOFNIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int IGHNHCKLCCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int DJCBBLEPNDP;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int HLOGIMCLHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA451A0", Offset = "0xA437A0", VA = "0x180A451A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x519B7F0", Offset = "0x5199DF0", VA = "0x18519B7F0")]
	public JFHJAGCOCBN(float HCKIAICAPFL, float HFMCPDFBPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x519ADE0", Offset = "0x51993E0", VA = "0x18519ADE0", Slot = "6")]
	public bool HJKCMKGBGGD(float PHDJLKIIBIL, T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x519B450", Offset = "0x5199A50", VA = "0x18519B450", Slot = "8")]
	public int LMHFKEMBEHM(float PHDJLKIIBIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x519B530", Offset = "0x5199B30", VA = "0x18519B530", Slot = "5")]
	[IteratorStateMachine(typeof(JFHJAGCOCBN<>.MKOHLMOHMCG))]
	public IEnumerable<T> PDPJOCNPGEN(float PHDJLKIIBIL, float? BMEAOJPINNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x519ADA0", Offset = "0x51993A0", VA = "0x18519ADA0", Slot = "7")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x519B370", Offset = "0x5199970", VA = "0x18519B370")]
	private void ICFOLDAPOGK(float PHDJLKIIBIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x519AC40", Offset = "0x5199240", VA = "0x18519AC40")]
	private FMOBDAJAFHG FOJMPKGJMOF()
	{
		return default(FMOBDAJAFHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EHMNEFALKGP<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct EGGMBCNFCLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long ABNFBMBDNFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long APGAJECMKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int MCOGBHOIEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int IPNMHPKOFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool EMMOABJANGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string DBMHNEIHPEF;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4783240", Offset = "0x4781840", VA = "0x184783240")]
		public EGGMBCNFCLB(long ABNFBMBDNFI, int MCOGBHOIEKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x47832B0", Offset = "0x47818B0", VA = "0x1847832B0")]
		public EGGMBCNFCLB(long ABNFBMBDNFI, long APGAJECMKKB, int MCOGBHOIEKH, int IPNMHPKOFFC, bool EMMOABJANGK, string DBMHNEIHPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x47831F0", Offset = "0x47817F0", VA = "0x1847831F0")]
		public int OACCAHIKIDG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4783170", Offset = "0x4781770", VA = "0x184783170")]
		public int BMLIMLOEPDF(int FFMHEADDKCK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4783190", Offset = "0x4781790", VA = "0x184783190")]
		public double HIFEKMJBKPJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x47830D0", Offset = "0x47816D0", VA = "0x1847830D0")]
		public EGGMBCNFCLB AECBBGCFPJE(long APGAJECMKKB, int IPNMHPKOFFC)
		{
			return default(EGGMBCNFCLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class OJMJGFAOFAB : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct BOGABDGABLE<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public OJMJGFAOFAB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<OJMJGFAOFAB, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private OJMJGFAOFAB <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x62F6640", Offset = "0x62F4C40", VA = "0x1862F6640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x478E1B0", Offset = "0x478C7B0", VA = "0x18478E1B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey MBLBFBKCCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly EHMNEFALKGP<TKey> GPIJGKLDGAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly LHMKAIAPMBI NDJJBNFFFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<OJMJGFAOFAB> CJACKIGODFC;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string HGPGJGMEGBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x57D6C80", Offset = "0x57D5280", VA = "0x1857D6C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<OJMJGFAOFAB> OOOMLMJLCLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x57D6AE0", Offset = "0x57D50E0", VA = "0x1857D6AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public EGGMBCNFCLB ICJELOAIHNA
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x57D6AC0", Offset = "0x57D50C0", VA = "0x1857D6AC0")]
			[CompilerGenerated]
			get
			{
				return default(EGGMBCNFCLB);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x57D6890", Offset = "0x57D4E90", VA = "0x1857D6890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x57D6CB0", Offset = "0x57D52B0", VA = "0x1857D6CB0")]
		internal OJMJGFAOFAB(EHMNEFALKGP<TKey> GPIJGKLDGAC, TKey BLIBAMJKLIA, LHMKAIAPMBI NDJJBNFFFGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x57D6B20", Offset = "0x57D5120", VA = "0x1857D6B20")]
		public OJMJGFAOFAB LHIAGKFONMA(TKey BLIBAMJKLIA, [Optional] LHMKAIAPMBI? APEEKPMHMDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x42B3C00", Offset = "0x42B2200", VA = "0x1842B3C00")]
		[AsyncStateMachine(typeof(BOGABDGABLE<>))]
		public Task<T> ODAOGGOPHFA<T>(TKey BLIBAMJKLIA, Func<OJMJGFAOFAB, Task<T>> OEPFDIIJHGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x57D68C0", Offset = "0x57D4EC0", VA = "0x1857D68C0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NGCNHAGOOKL : IEnumerable<(TKey, List<TKey>, EGGMBCNFCLB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EGGMBCNFCLB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, EGGMBCNFCLB timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EHMNEFALKGP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, EGGMBCNFCLB timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, EGGMBCNFCLB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2C03890", Offset = "0x2C01E90", VA = "0x182C03890", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EGGMBCNFCLB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x568B0B0", Offset = "0x56896B0", VA = "0x18568B0B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2C03980", Offset = "0x2C01F80", VA = "0x182C03980")]
		[DebuggerHidden]
		public NGCNHAGOOKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4CD68B0", Offset = "0x4CD4EB0", VA = "0x184CD68B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x568AC00", Offset = "0x5689200", VA = "0x18568AC00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x568ABB0", Offset = "0x56891B0", VA = "0x18568ABB0")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x568B060", Offset = "0x5689660", VA = "0x18568B060", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x568AFA0", Offset = "0x56895A0", VA = "0x18568AFA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EGGMBCNFCLB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4CE0120", Offset = "0x4CDE720", VA = "0x184CE0120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class JOEIFPFHKGN : IEnumerable<(TKey, List<TKey>, EGGMBCNFCLB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EGGMBCNFCLB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, EGGMBCNFCLB timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private OJMJGFAOFAB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public OJMJGFAOFAB <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EHMNEFALKGP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<OJMJGFAOFAB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, EGGMBCNFCLB timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, EGGMBCNFCLB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2C03890", Offset = "0x2C01E90", VA = "0x182C03890", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EGGMBCNFCLB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x51DE4D0", Offset = "0x51DCAD0", VA = "0x1851DE4D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2C03980", Offset = "0x2C01F80", VA = "0x182C03980")]
		[DebuggerHidden]
		public JOEIFPFHKGN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x51DE530", Offset = "0x51DCB30", VA = "0x1851DE530", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x51DDB70", Offset = "0x51DC170", VA = "0x1851DDB70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x51DDB10", Offset = "0x51DC110", VA = "0x1851DDB10")]
		private void APENNGMAANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x51DE310", Offset = "0x51DC910", VA = "0x1851DE310")]
		private void NECCDOCMECN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x51DE480", Offset = "0x51DCA80", VA = "0x1851DE480", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x51DE370", Offset = "0x51DC970", VA = "0x1851DE370", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EGGMBCNFCLB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x51DE450", Offset = "0x51DCA50", VA = "0x1851DE450", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, EGGMBCNFCLB, LHMKAIAPMBI> OEMAKEEHHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, EGGMBCNFCLB, LHMKAIAPMBI> CJHBBDHCANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<EHMNEFALKGP<TKey>, LHMKAIAPMBI> PHOMBPDMKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly LHMKAIAPMBI NDJJBNFFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly OJMJGFAOFAB JDLFNBOCHFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool IPJFEJDAGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int CEJEKAMIMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch HADOOGNBGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int KKKKGIGDPJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string BNAFKKKCGHD;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public OJMJGFAOFAB FNDMDMKJMBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string HGPGJGMEGBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA44960", Offset = "0xA42F60", VA = "0x180A44960")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x478AD50", Offset = "0x4789350", VA = "0x18478AD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x478ADB0", Offset = "0x47893B0", VA = "0x18478ADB0")]
	public EHMNEFALKGP(TKey GJBABGIFKFO, LHMKAIAPMBI NDJJBNFFFGK, [Optional] int? MCOGBHOIEKH, [Optional][CanBeNull] Stopwatch HADOOGNBGEH, [Optional] Action<TKey, EGGMBCNFCLB, LHMKAIAPMBI> OEMAKEEHHLD, [Optional] Action<TKey, EGGMBCNFCLB, LHMKAIAPMBI> CJHBBDHCANM, [Optional] Action<EHMNEFALKGP<TKey>, LHMKAIAPMBI> PHOMBPDMKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x478AC40", Offset = "0x4789240", VA = "0x18478AC40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x478ABB0", Offset = "0x47891B0", VA = "0x18478ABB0")]
	[IteratorStateMachine(typeof(EHMNEFALKGP<>.NGCNHAGOOKL))]
	public IEnumerable<(TKey, List<TKey>, EGGMBCNFCLB)> AHAICDCPPCP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x478AAE0", Offset = "0x47890E0", VA = "0x18478AAE0")]
	[IteratorStateMachine(typeof(EHMNEFALKGP<>.JOEIFPFHKGN))]
	private IEnumerable<(TKey, List<TKey>, EGGMBCNFCLB)> AHAICDCPPCP(List<TKey> HIOPFIEJGKH, OJMJGFAOFAB PFAHMJFBIOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x478ACD0", Offset = "0x47892D0", VA = "0x18478ACD0")]
	private (long, int) KGEKLFKBGDG()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class IGKJMOMEOFF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut EPIKLCKNAIK(EHMNEFALKGP<TKey> GPIJGKLDGAC);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected IGKJMOMEOFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class FBCIOCNBOBJ<TKey> : IGKJMOMEOFF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string DBEJFLOCFFP(TKey BLIBAMJKLIA);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4BF2210", Offset = "0x4BF0810", VA = "0x184BF2210")]
	private static string KBIELCEGOAI(TKey BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4BF2000", Offset = "0x4BF0600", VA = "0x184BF2000", Slot = "4")]
	public override string EPIKLCKNAIK(EHMNEFALKGP<TKey> GPIJGKLDGAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4BF20C0", Offset = "0x4BF06C0", VA = "0x184BF20C0")]
	public string EPIKLCKNAIK(EHMNEFALKGP<TKey> GPIJGKLDGAC, [NotNull] DBEJFLOCFFP FJMFLPIPKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string GEKEIDCMJFA(EHMNEFALKGP<TKey> GPIJGKLDGAC, [NotNull] DBEJFLOCFFP FJMFLPIPKKD);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4BF2250", Offset = "0x4BF0850", VA = "0x184BF2250")]
	protected FBCIOCNBOBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class PHOGCGKBNPN<TKey> : IGKJMOMEOFF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string KAMADMJMJHO(TKey BLIBAMJKLIA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string IFCCCMNAANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double KKOKBOPPOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool PLEJLKJKBLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int PPKMBCHHCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> FKKADDDACOB;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x58DD5C0", Offset = "0x58DBBC0", VA = "0x1858DD5C0")]
	private static string KBIELCEGOAI(TKey BLIBAMJKLIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x58DD600", Offset = "0x58DBC00", VA = "0x1858DD600")]
	public PHOGCGKBNPN(string IFCCCMNAANN = "F2", double KKOKBOPPOED = double.MaxValue, bool PLEJLKJKBLJ = false, int PPKMBCHHCNI = int.MaxValue, [Optional] ISet<string> FKKADDDACOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x58DD2C0", Offset = "0x58DB8C0", VA = "0x1858DD2C0", Slot = "4")]
	public override Dictionary<string, string> EPIKLCKNAIK(EHMNEFALKGP<TKey> GPIJGKLDGAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x58DCC00", Offset = "0x58DB200", VA = "0x1858DCC00")]
	private bool CEGKMBIFIBC(string CJNFOCKKEHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x58DCCD0", Offset = "0x58DB2D0", VA = "0x1858DCCD0")]
	public Dictionary<string, string> EPIKLCKNAIK(EHMNEFALKGP<TKey> GPIJGKLDGAC, KAMADMJMJHO FJMFLPIPKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x58DD380", Offset = "0x58DB980", VA = "0x1858DD380")]
	private string FOMHHICBODG(StringBuilder CBLGLCPGMPO, List<TKey> MOFBMGPGMFI, KAMADMJMJHO FJMFLPIPKKD, bool LGKDPFCDHNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x58DCAA0", Offset = "0x58DB0A0", VA = "0x1858DCAA0")]
	private static void BMHDNLDBJIC(StringBuilder HPAGEGHIOND, string IGANAFFFAEL, bool EAENEFPEIJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KLGGHIEHOPO<TKey> : FBCIOCNBOBJ<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FJNJLDIFCFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public DBEJFLOCFFP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static KLGGHIEHOPO<TKey> FNIBPMLJKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] BPKPKBAFHJO;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x52DDB90", Offset = "0x52DC190", VA = "0x1852DDB90")]
	private KLGGHIEHOPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x52DCB30", Offset = "0x52DB130", VA = "0x1852DCB30", Slot = "5")]
	protected override string GEKEIDCMJFA(EHMNEFALKGP<TKey> GPIJGKLDGAC, DBEJFLOCFFP FJMFLPIPKKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x52DD960", Offset = "0x52DBF60", VA = "0x1852DD960")]
	[CompilerGenerated]
	internal static string LOHMAAKHEAF(string CLGIDHKIIKN, TKey BLIBAMJKLIA, FJNJLDIFCFF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class JHOMEKMEMEK : EHMNEFALKGP<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class ECKIONBCKFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<JHOMEKMEMEK, LHMKAIAPMBI> callback;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ECKIONBCKFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7F6D6D0", Offset = "0x7F6BCD0", VA = "0x187F6D6D0")]
		internal void FDHAADOJCKN(EHMNEFALKGP<string> timer, LHMKAIAPMBI log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F090", Offset = "0x7F6D690", VA = "0x187F6F090")]
	public JHOMEKMEMEK(LHMKAIAPMBI NDJJBNFFFGK, [Optional] string BEPJOICBAPD, [Optional] int? MCOGBHOIEKH, [Optional] Stopwatch HADOOGNBGEH, [Optional] Action<string, EGGMBCNFCLB, LHMKAIAPMBI> OEMAKEEHHLD, [Optional] Action<string, EGGMBCNFCLB, LHMKAIAPMBI> CJHBBDHCANM, [Optional] Action<JHOMEKMEMEK, LHMKAIAPMBI> PHOMBPDMKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EFD0", Offset = "0x7F6D5D0", VA = "0x187F6EFD0")]
	private static Action<EHMNEFALKGP<string>, LHMKAIAPMBI> APPEOMCIJGF(Action<JHOMEKMEMEK, LHMKAIAPMBI> BNOBGIHHJGL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class ICLCICDAANK
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class KICBFDLKDEM : ICLCICDAANK
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static ICLCICDAANK FNIBPMLJKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x7F6F2B0", Offset = "0x7F6D8B0", VA = "0x187F6F2B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float LFHKKJEKKFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x12AED70", Offset = "0x12AD370", VA = "0x1812AED70", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7F6F3B0", Offset = "0x7F6D9B0", VA = "0x187F6F3B0")]
		public KICBFDLKDEM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static ICLCICDAANK IEFAEPOAPNA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static ICLCICDAANK JLODNOEBAIE
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7F6EE60", Offset = "0x7F6D460", VA = "0x187F6EE60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float LFHKKJEKKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected ICLCICDAANK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface DKAHIDLCKHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool FLBBOPEIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface MODONOMENDG<T> : DKAHIDLCKHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> DEANIHNBCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	EHBLMFNEKIG<T> LJLPBMBFPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class IHKFPJMBALP
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3B7D980", Offset = "0x3B7BF80", VA = "0x183B7D980")]
	public static MODONOMENDG<TResource> OLLLMAICFHO<TResource, TId>(this DBPOMMLFDMH<TId, TResource> BBCMOCJMBOF, TId HLIPPIOIAJK, [Optional] Func<TId, CancellationToken, Task<TResource>>? EKAOBFNKFLN) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class CIEOKEJHPCF
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class INNFBGJHAHJ<T> : IDJEJKJJLCA<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> DEANIHNBCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override EHBLMFNEKIG<T?> LJLPBMBFPNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4F9E630", Offset = "0x4F9CC30", VA = "0x184F9E630")]
		public INNFBGJHAHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "10")]
		protected override void HHOFCNJENML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class PNBEIFCAKIO<T> : IDJEJKJJLCA<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T NPLMMJNKANL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? PPGFFLPCJAC;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> DEANIHNBCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override EHBLMFNEKIG<T> LJLPBMBFPNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA47BC0", Offset = "0xA461C0", VA = "0x180A47BC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x58F5DA0", Offset = "0x58F43A0", VA = "0x1858F5DA0")]
		public PNBEIFCAKIO(T JGGFCLCGOGI, Action<T>? LJIEFCNIMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x58F5BF0", Offset = "0x58F41F0", VA = "0x1858F5BF0", Slot = "10")]
		protected override void HHOFCNJENML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class FONFOMLIHDJ<T> : IDJEJKJJLCA<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> DEANIHNBCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override EHBLMFNEKIG<T> LJLPBMBFPNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x4C8E390", Offset = "0x4C8C990", VA = "0x184C8E390")]
		public FONFOMLIHDJ(Exception DHMKLCNLGMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "10")]
		protected override void HHOFCNJENML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class DNAGLDCFFLN<T> : IDJEJKJJLCA<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct KIMNHMLFIFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<MODONOMENDG<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<MODONOMENDG<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x52D4E10", Offset = "0x52D3410", VA = "0x1852D4E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x52D5320", Offset = "0x52D3920", VA = "0x1852D5320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct IFMGCFENGEM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<MODONOMENDG<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<MODONOMENDG<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4F60420", Offset = "0x4F5EA20", VA = "0x184F60420", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4F608E0", Offset = "0x4F5EEE0", VA = "0x184F608E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<MODONOMENDG<T>> FBCBAEPJKCM;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> DEANIHNBCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override EHBLMFNEKIG<T> LJLPBMBFPNH
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6D2ACC0", Offset = "0x6D292C0", VA = "0x186D2ACC0")]
		public DNAGLDCFFLN(Task<MODONOMENDG<T>> NPLKHMALANM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x6D2AA50", Offset = "0x6D29050", VA = "0x186D2AA50", Slot = "10")]
		protected override void HHOFCNJENML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6D2A860", Offset = "0x6D28E60", VA = "0x186D2A860")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(DNAGLDCFFLN<>.KIMNHMLFIFO))]
		internal static Task<T> FPPHJNNKIJL(Task<MODONOMENDG<T>> NPLKHMALANM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6D2AAE0", Offset = "0x6D290E0", VA = "0x186D2AAE0")]
		[AsyncStateMachine(typeof(DNAGLDCFFLN<>.IFMGCFENGEM))]
		[CompilerGenerated]
		internal static Task IMOFBICGCDB(Task<MODONOMENDG<T>> NPLKHMALANM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class ONOGAMLKILM<TIn, TOut> : IDJEJKJJLCA<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct IDMDOGEBBPG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x4F54A80", Offset = "0x4F53080", VA = "0x184F54A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x4F55110", Offset = "0x4F53710", VA = "0x184F55110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly MODONOMENDG<TIn> CMGPJPKKAMC;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> DEANIHNBCOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override EHBLMFNEKIG<TOut> LJLPBMBFPNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x57E48D0", Offset = "0x57E2ED0", VA = "0x1857E48D0")]
		public ONOGAMLKILM(MODONOMENDG<TIn> PPIFJMNMGBA, Func<TIn, TOut> CEKFCEEECCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x57E4530", Offset = "0x57E2B30", VA = "0x1857E4530", Slot = "10")]
		protected override void HHOFCNJENML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x57E45D0", Offset = "0x57E2BD0", VA = "0x1857E45D0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(ONOGAMLKILM<, >.IDMDOGEBBPG))]
		internal static Task<TOut> OANGJNNCNNE(Task<TIn> DNOLAMGPFHN, Func<TIn, TOut> CEKFCEEECCJ)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x39505A0", Offset = "0x394EBA0", VA = "0x1839505A0")]
	public static MODONOMENDG<T> PBMJKPJDLCC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3950510", Offset = "0x394EB10", VA = "0x183950510")]
	public static MODONOMENDG<T> DOAKGADDJOE<T>(T HPCDHGHHCOO, [Optional] Action<T>? LJIEFCNIMHE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x39504A0", Offset = "0x394EAA0", VA = "0x1839504A0")]
	public static MODONOMENDG<T> APPJIOOECDM<T>(Exception DHMKLCNLGMO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x39504A0", Offset = "0x394EAA0", VA = "0x1839504A0")]
	public static MODONOMENDG<T> LNPAEHHIIFC<T>(Task<MODONOMENDG<T>> NPLKHMALANM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x30ACE80", Offset = "0x30AB480", VA = "0x1830ACE80")]
	public static MODONOMENDG<TOut> BDBOCHCKBIN<TOut, TIn>(MODONOMENDG<TIn> MNCGAKBHIPL, Func<TIn, TOut> CEKFCEEECCJ) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class IDJEJKJJLCA<T> : MODONOMENDG<T>, DKAHIDLCKHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string AHMAIMCJJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly DALACCGALDC EHNFHNCHLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool IPJFEJDAGIO;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool FLBBOPEIKLE
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xAC2F70", Offset = "0xAC1570", VA = "0x180AC2F70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> DEANIHNBCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract EHBLMFNEKIG<T> LJLPBMBFPNH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4F549B0", Offset = "0x4F52FB0", VA = "0x184F549B0")]
	public IDJEJKJJLCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4F545F0", Offset = "0x4F52BF0", VA = "0x184F545F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void HHOFCNJENML();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class JLCFMPFODIO<TTask, T> : IDJEJKJJLCA<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class LPDKIGBAJGJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public LPDKIGBAJGJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x430D250", Offset = "0x430B850", VA = "0x18430D250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x430D7C0", Offset = "0x430BDC0", VA = "0x18430D7C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public JLCFMPFODIO<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public LPDKIGBAJGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x54397F0", Offset = "0x5437DF0", VA = "0x1854397F0")]
		[AsyncStateMachine(typeof(JLCFMPFODIO<, >.LPDKIGBAJGJ.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> KPJJBDJFPDB(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> NPLKHMALANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource PCGMGJPANKK;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> DEANIHNBCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override EHBLMFNEKIG<T> LJLPBMBFPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x51DA2A0", Offset = "0x51D88A0", VA = "0x1851DA2A0")]
	protected JLCFMPFODIO(TTask NPLKHMALANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x51DA250", Offset = "0x51D8850", VA = "0x1851DA250", Slot = "10")]
	protected override void HHOFCNJENML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T CJAKMKBGKOP(TTask PPPKJJELICO);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void LGNABDJFKGF();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class FOPMFNDLOOF<T> : IDJEJKJJLCA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly PGDJPLOBHJM<Task<T>> NOLGEBHEBCN;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> DEANIHNBCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4C8EE70", Offset = "0x4C8D470", VA = "0x184C8EE70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override EHBLMFNEKIG<T> LJLPBMBFPNH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EED0", Offset = "0x4C8D4D0", VA = "0x184C8EED0")]
	public FOPMFNDLOOF(PGDJPLOBHJM<Task<T>> ICEGOLPGFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EEB0", Offset = "0x4C8D4B0", VA = "0x184C8EEB0", Slot = "10")]
	protected override void HHOFCNJENML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class KJOBDPMADFA
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName JMJBBHPAPGI;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> BLFAOFDODFC;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F490", Offset = "0x7F6DA90", VA = "0x187F6F490")]
	public static int MAJODDBCLOH(this HGDAOBPFKGG JAJDFGMKDDK, IncrementalHash GOFLPLJKKOO, byte[] IAACINJDENF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F830", Offset = "0x7F6DE30", VA = "0x187F6F830")]
	public static bool PFIAJIAJCJA([CanBeNull] this HGDAOBPFKGG JAJDFGMKDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F520", Offset = "0x7F6DB20", VA = "0x187F6F520")]
	public static bool PFIAJIAJCJA([CanBeNull] this HGDAOBPFKGG JAJDFGMKDDK, [Out] string NNDNCFBMBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F890", Offset = "0x7F6DE90", VA = "0x187F6F890")]
	public static bool PFIAJIAJCJA([CanBeNull] this HGDAOBPFKGG JAJDFGMKDDK, IncrementalHash GOFLPLJKKOO, byte[] IAACINJDENF, [Out] string NNDNCFBMBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7F6F400", Offset = "0x7F6DA00", VA = "0x187F6F400")]
	private static bool BMBEEAELJFL(byte[] BEAABHNPMLP, Span<byte> CKFHAJBIMFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class MGJBLGGHGIL
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FDE0", Offset = "0x7F6E3E0", VA = "0x187F6FDE0")]
	public static int AFKDIJFLCLN(HashAlgorithmName CDAEGBPMMPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3C12BB0", Offset = "0x3C111B0", VA = "0x183C12BB0")]
	public static int MAJODDBCLOH<T>(this T INCKDACPMBD, byte[] FGKFGOEFIKN, IncrementalHash GOFLPLJKKOO, byte[] ONMAHLPPGJC) where T : ACALJOKAGIL
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface ACALJOKAGIL
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash GOFLPLJKKOO);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface HGDAOBPFKGG : ACALJOKAGIL
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] LAGDJPDFKNG
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] JFHPNNGMJGN
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class HECCJNOEHKO
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool GAKDPKPAKLA;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> FJLDNDOFEHF;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> NCPBKNGEAPB;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding LCMIDIKDHKJ;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> CJENNKKOMAC;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E360", Offset = "0x3B5C960", VA = "0x183B5E360")]
	public static void KBLCBGJDPBM<T>(this IncrementalHash OBLKJIHLFBB, [CanBeNull] T DNCHHBPCLHH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E2D0", Offset = "0x3B5C8D0", VA = "0x183B5E2D0")]
	public static void CBGFMBNHHBC<T>(this IncrementalHash OBLKJIHLFBB, [CanBeNull] T INCKDACPMBD) where T : ACALJOKAGIL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E420", Offset = "0x3B5CA20", VA = "0x183B5E420")]
	public static void MNKEFOEEHDD<T>(this IncrementalHash OBLKJIHLFBB, [CanBeNull] IList<T> HLGFOHNKADH) where T : ACALJOKAGIL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E7D0", Offset = "0x7F6CDD0", VA = "0x187F6E7D0")]
	private static bool IBMCNFKNOGJ([CanBeNull] ACALJOKAGIL INCKDACPMBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DD80", Offset = "0x7F6C380", VA = "0x187F6DD80")]
	public static void BPBNHIDPOJD(this IncrementalHash GOFLPLJKKOO, string? CHBCOGPFOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E3D0", Offset = "0x7F6C9D0", VA = "0x187F6E3D0")]
	public static void DPIODIBFCBH(this IncrementalHash GOFLPLJKKOO, long PLJJFKOKOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E600", Offset = "0x7F6CC00", VA = "0x187F6E600")]
	public static void GGBMLBGPLIB(this IncrementalHash GOFLPLJKKOO, int KFGCNGONIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E860", Offset = "0x7F6CE60", VA = "0x187F6E860")]
	public static void LHOJPNEMGCO(this IncrementalHash GOFLPLJKKOO, short BBHFJGLJPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E2C0", Offset = "0x7F6C8C0", VA = "0x187F6E2C0")]
	public static void CJCJMJOGKIJ(this IncrementalHash GOFLPLJKKOO, byte BMBOIFOKCNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DC10", Offset = "0x7F6C210", VA = "0x187F6DC10")]
	public static void BADDDDCJELG(this IncrementalHash GOFLPLJKKOO, bool DFFGGDLFENG, bool HOLMDJDHCFC = false, bool HMKFCAHNACA = false, bool EFFOMMDDKEM = false, bool FONPNPKOOEB = false, bool JOHPCPCLEPO = false, bool MLCLMILLGKH = false, bool NBJFONDEIFJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3B5E940", Offset = "0x3B5CF40", VA = "0x183B5E940")]
	public static void NJKDMEKDNOC<T>(this IncrementalHash GOFLPLJKKOO, T DANMPOCKLCI) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EAF0", Offset = "0x7F6D0F0", VA = "0x187F6EAF0")]
	public static void PLJMCHMAJGE(this IncrementalHash GOFLPLJKKOO, float NCPBEEGHJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EA90", Offset = "0x7F6D090", VA = "0x187F6EA90")]
	public static void OEBBLLILBHL(this IncrementalHash GOFLPLJKKOO, ulong ONDGLKNDBHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7F6EA30", Offset = "0x7F6D030", VA = "0x187F6EA30")]
	public static void NLPGNKNMOLO(this IncrementalHash GOFLPLJKKOO, uint HBIPLGLNPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E5A0", Offset = "0x7F6CBA0", VA = "0x187F6E5A0")]
	public static void EKEBDOFIKNP(this IncrementalHash GOFLPLJKKOO, ushort PBABCBHOJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7F6E190", Offset = "0x7F6C790", VA = "0x187F6E190")]
	public static void CDMECKPHHCD(this IncrementalHash GOFLPLJKKOO, Vector3 IFEMDEIOLJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class AGFPOEOOKGN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D210", Offset = "0x7F6B810", VA = "0x187F6D210")]
	public AGFPOEOOKGN(string CJIMOMNMAGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class GCEONAHMPDI
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void HBNIPEBMIOI(ushort GPJKGLBNGHM, ushort ODHFNKBJBIF, ushort JKDHOCOHBOC, ushort AFIBPELNMBP);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void EHBHHDMJNNL(ushort CEJHLHMFFJF, ushort DBFLGDPMGAD);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void GEICGOMEKJI();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort CMDJLCFGCKJ = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected GCEONAHMPDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class FEBEBBPGOMJ<T> : GCEONAHMPDI where T : FEBEBBPGOMJ<T>.ECMCPPLFFOA
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface ECMCPPLFFOA
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		EHBHHDMJNNL AIDKJKDDOGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		EHBHHDMJNNL HGDFAEKMENM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		GEICGOMEKJI BJOIDGPCGCL
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> FMCCGNIJONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private GEICGOMEKJI HMBEAKDJEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private GEICGOMEKJI MPPFBCCLHGN;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool GECBOKDKAEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAA5D80", Offset = "0xAA4380", VA = "0x180AA5D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA441A0", Offset = "0xA427A0", VA = "0x180A441A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort MBPLNCNGCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1173630", Offset = "0x1171C30", VA = "0x181173630")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x1173420", Offset = "0x1171A20", VA = "0x181173420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort NLPKCCCIBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8DA0", Offset = "0x4BF73A0", VA = "0x184BF8DA0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8E70", Offset = "0x4BF7470", VA = "0x184BF8E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort MNHKMGDBKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xE8CE60", Offset = "0xE8B460", VA = "0x180E8CE60")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xE8CF80", Offset = "0xE8B580", VA = "0x180E8CF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort MDOJODPINBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4BF92B0", Offset = "0x4BF78B0", VA = "0x184BF92B0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8DB0", Offset = "0x4BF73B0", VA = "0x184BF8DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool OCEFOPEJMNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x11732E0", Offset = "0x11718E0", VA = "0x1811732E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool HCJOOAIAKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xF80210", Offset = "0xF7E810", VA = "0x180F80210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event HBNIPEBMIOI ILFDAKIMNNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4BF9210", Offset = "0x4BF7810", VA = "0x184BF9210")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4BF8DD0", Offset = "0x4BF73D0", VA = "0x184BF8DD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4BF92C0", Offset = "0x4BF78C0", VA = "0x184BF92C0")]
	private T OIHDHAGNABN(ushort JLIMCNCAMMD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9140", Offset = "0x4BF7740", VA = "0x184BF9140")]
	private T JCMPNAMPPBD(ushort JLIMCNCAMMD, ushort NHOGIDLEGCP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4BF8D50", Offset = "0x4BF7350", VA = "0x184BF8D50")]
	protected T DHEMEBNBDBI(uint NKAJEAPIJJG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9490", Offset = "0x4BF7A90", VA = "0x184BF9490")]
	protected FEBEBBPGOMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9470", Offset = "0x4BF7A70", VA = "0x184BF9470")]
	public void PFGIIOMNNEO(ushort FLGKNNKGGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9350", Offset = "0x4BF7950", VA = "0x184BF9350")]
	public void PFGIIOMNNEO(ushort FLGKNNKGGPN, ushort NGOCKEMEHAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4BF93A0", Offset = "0x4BF79A0", VA = "0x184BF93A0", Slot = "4")]
	protected virtual void PFGIIOMNNEO(uint ICIDAEHPHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4BF85D0", Offset = "0x4BF6BD0", VA = "0x184BF85D0")]
	protected void BLCEMNKDJNN(uint ICIDAEHPHEP, uint OAJNJNHMBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4BF8E80", Offset = "0x4BF7480", VA = "0x184BF8E80")]
	protected void IAHDKECLDJF(ushort JLIMCNCAMMD, ushort NHOGIDLEGCP, T DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4BF91D0", Offset = "0x4BF77D0", VA = "0x184BF91D0")]
	private void MBCBKJHHNGP(uint NKAJEAPIJJG, T DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4BF8EF0", Offset = "0x4BF74F0", VA = "0x184BF8EF0")]
	protected void JAGDNLHLMEF(float OGJBAEEMPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4BF9200", Offset = "0x4BF7800", VA = "0x184BF9200")]
	protected uint NEIAMBLIFFB(ushort JLIMCNCAMMD, ushort NHOGIDLEGCP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4BF8DC0", Offset = "0x4BF73C0", VA = "0x184BF8DC0")]
	protected ushort FGKIJHGACNI(uint CDEEAMEADIB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4BF85C0", Offset = "0x4BF6BC0", VA = "0x184BF85C0")]
	protected ushort BEEEBGJKIAP(uint CDEEAMEADIB)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class FECPOBMBIBA : FEBEBBPGOMJ<FECPOBMBIBA.EMIIEJDMJOE>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class EMIIEJDMJOE : ECMCPPLFFOA
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public EHBHHDMJNNL AIDKJKDDOGO
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA44190", Offset = "0xA42790", VA = "0x180A44190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public EHBHHDMJNNL HGDFAEKMENM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public GEICGOMEKJI BJOIDGPCGCL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA451B0", Offset = "0xA437B0", VA = "0x180A451B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public EMIIEJDMJOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D980", Offset = "0x7F6BF80", VA = "0x187F6D980")]
	public void ONALANLDMPK(ushort DKKPBAHFONE, EHBHHDMJNNL GECEBGKHLKL, EHBHHDMJNNL ILPMFEFLCGN, GEICGOMEKJI LLKEOFIKBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D8A0", Offset = "0x7F6BEA0", VA = "0x187F6D8A0")]
	public void ONALANLDMPK(ushort JLIMCNCAMMD, ushort NHOGIDLEGCP, EHBHHDMJNNL GECEBGKHLKL, EHBHHDMJNNL ILPMFEFLCGN, GEICGOMEKJI LLKEOFIKBJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F6D850", Offset = "0x7F6BE50", VA = "0x187F6D850")]
	public void IEMAIHNOLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DA60", Offset = "0x7F6C060", VA = "0x187F6DA60")]
	protected FECPOBMBIBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MCCEFIPINHJ : FECPOBMBIBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool FBIHAAGDJHM;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool ICKKICKDNIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xCCADC0", Offset = "0xCC93C0", VA = "0x180CCADC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xDC9890", Offset = "0xDC7E90", VA = "0x180DC9890")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FD20", Offset = "0x7F6E320", VA = "0x187F6FD20")]
	public void FLMOPKJJIJF(ushort MHDCAGGBLPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7F6FD80", Offset = "0x7F6E380", VA = "0x187F6FD80")]
	public void FLMOPKJJIJF(ushort MHDCAGGBLPI, ushort ENNKAJJAABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F6DA60", Offset = "0x7F6C060", VA = "0x187F6DA60")]
	public MCCEFIPINHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class OKDPGILDABL<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class OLMGPJCGLPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode PIKMBNLEPPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode NBIJLPJHNNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public LILJCGAOACC FMBOIKGHIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<LILJCGAOACC> FJHMELFHCGE;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public OLMGPJCGLPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct LILJCGAOACC : IComparable<LILJCGAOACC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int FKHLDNNBKMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant BPMHJAONGKB;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x17F5060", Offset = "0x17F3660", VA = "0x1817F5060")]
		public LILJCGAOACC(int FKHLDNNBKMB, TClaimant BPMHJAONGKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x53917F0", Offset = "0x538FDF0", VA = "0x1853917F0")]
		public bool FGIODCOAAHM([In] LILJCGAOACC HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5391850", Offset = "0x538FE50", VA = "0x185391850")]
		public bool OMKJHLBJECE([In] LILJCGAOACC HOPHFOOKMCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x53917E0", Offset = "0x538FDE0", VA = "0x1853917E0", Slot = "4")]
		public int CompareTo(LILJCGAOACC HOPHFOOKMCC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5391860", Offset = "0x538FE60", VA = "0x185391860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum CKOCGGLOKOO
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class MMFLLBGMJEM : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public OKDPGILDABL<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xF4E730", Offset = "0xF4CD30", VA = "0x180F4E730")]
		[DebuggerHidden]
		public MMFLLBGMJEM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5614170", Offset = "0x5612770", VA = "0x185614170", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5614330", Offset = "0x5612930", VA = "0x185614330", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5614250", Offset = "0x5612850", VA = "0x185614250", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4CD8100", Offset = "0x4CD6700", VA = "0x184CD8100", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly CKMEAMFPAKH<OLMGPJCGLPJ> JGCIKBALFLK;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly CKMEAMFPAKH<List<LILJCGAOACC>> BAPDFCPIEAJ;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int GDBPOLBGEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> CPBPDLJLEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, OLMGPJCGLPJ> IEDLMOKNLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private CKOCGGLOKOO HMNPOEHONDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool DNDJADKEJII;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode BJFCBLMDKHF(TNode ADFICJOCHFA);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void NIHAEFNHOJE(TNode ADFICJOCHFA, TClaimant ADILDLFDLLN, TClaimant ACBOBLAPFOI);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x57D8A00", Offset = "0x57D7000", VA = "0x1857D8A00")]
	public OKDPGILDABL(CKOCGGLOKOO HMNPOEHONDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x57D7F60", Offset = "0x57D6560", VA = "0x1857D7F60")]
	public void MKDNPDLLOEA(TNode ADFICJOCHFA, TNode BADBAFBEKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x57D7E40", Offset = "0x57D6440", VA = "0x1857D7E40")]
	public void LNOABBKNDIL(TClaimant BPMHJAONGKB, TNode OHKICNKFDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x57D7700", Offset = "0x57D5D00", VA = "0x1857D7700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x57D8160", Offset = "0x57D6760", VA = "0x1857D8160")]
	private void NOJBMLDNFBJ(TClaimant BPMHJAONGKB, TNode KDIMDDJMCKB, TNode OHKICNKFDEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x57D7CC0", Offset = "0x57D62C0", VA = "0x1857D7CC0")]
	private int KHBCOFFADCB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x57D7330", Offset = "0x57D5930", VA = "0x1857D7330")]
	private void CCFICPOBOPJ(TClaimant BPMHJAONGKB, TNode BBDNHGBEMOJ, TNode GPPFMBFLIBE, int BHGKFHKOHNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x57D7670", Offset = "0x57D5C70", VA = "0x1857D7670")]
	private void DEDEKMILLPJ(LILJCGAOACC EDNHAFDLEJN, OLMGPJCGLPJ ANABIAJOBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x57D8200", Offset = "0x57D6800", VA = "0x1857D8200")]
	private void PDIOOEKDPAO(TClaimant BPMHJAONGKB, TNode BBDNHGBEMOJ, TNode GPPFMBFLIBE, int BHGKFHKOHNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x57D7D30", Offset = "0x57D6330", VA = "0x1857D7D30")]
	private void LLLEEACMPKI(LILJCGAOACC EDNHAFDLEJN, TNode ADFICJOCHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x57D7BD0", Offset = "0x57D61D0", VA = "0x1857D7BD0")]
	private void JLEIDLFJHPA(LILJCGAOACC EDNHAFDLEJN, OLMGPJCGLPJ ANABIAJOBHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x57D78D0", Offset = "0x57D5ED0", VA = "0x1857D78D0")]
	private void HBGKGJNILJL(OLMGPJCGLPJ ANABIAJOBHJ, bool DJKNGNDJOKP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x57D84E0", Offset = "0x57D6AE0", VA = "0x1857D84E0")]
	private void PPHPLOPKLNC(OLMGPJCGLPJ ANABIAJOBHJ, TNode BADBAFBEKHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x57D7AF0", Offset = "0x57D60F0", VA = "0x1857D7AF0")]
	[IteratorStateMachine(typeof(OKDPGILDABL<, >.MMFLLBGMJEM))]
	private IEnumerable<TNode> HENMMOMHBLO(TNode BBDNHGBEMOJ, TNode GPPFMBFLIBE, bool BICMHJDGKOA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x57D7A00", Offset = "0x57D6000", VA = "0x1857D7A00")]
	private OLMGPJCGLPJ HCKAOBMKAHG(TNode ADFICJOCHFA, TNode NBIJLPJHNNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x57D71C0", Offset = "0x57D57C0", VA = "0x1857D71C0")]
	private OLMGPJCGLPJ ACAPDLGNPKI(TNode ADFICJOCHFA, TNode NBIJLPJHNNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x57D7FF0", Offset = "0x57D65F0", VA = "0x1857D7FF0")]
	private void NHAHLELEFAI(OLMGPJCGLPJ ANABIAJOBHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class GMEIMEMACBJ<T> : IEnumerable<GMEIMEMACBJ<T>.BNHNNGJEGNL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct BNHNNGJEGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T KKGBKLFKCPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int KHMHPNKMLMD;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class CFLEMGFFAGO : IEnumerator<BNHNNGJEGNL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private GMEIMEMACBJ<T> DIJLOLAHCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int KHMHPNKMLMD;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x47A2FF0", Offset = "0x47A15F0", VA = "0x1847A2FF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public BNHNNGJEGNL CGHPBCAOGAD
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x679AA30", Offset = "0x6799030", VA = "0x18679AA30", Slot = "4")]
			get
			{
				return default(BNHNNGJEGNL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x679A940", Offset = "0x6798F40", VA = "0x18679A940")]
		public CFLEMGFFAGO(GMEIMEMACBJ<T> DIJLOLAHCLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x679A8C0", Offset = "0x6798EC0", VA = "0x18679A8C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4808D60", Offset = "0x4807360", VA = "0x184808D60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x121E280", Offset = "0x121C880", VA = "0x18121E280", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct MFJOBJNBKDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool FAPCEFKBLEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T KKGBKLFKCPO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int BBGMLOBHGGF = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> FLLGFIPCMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private MFJOBJNBKDO[] HFEAMMNKMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int FPFFIGNBLJC;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int DPJELHCMEHK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAB10B0", Offset = "0xAAF6B0", VA = "0x180AB10B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xFA8E10", Offset = "0xFA7410", VA = "0x180FA8E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x43253A0", Offset = "0x43239A0", VA = "0x1843253A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4D9CE60", Offset = "0x4D9B460", VA = "0x184D9CE60")]
	public GMEIMEMACBJ(int BJPLKLLFDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4D9CA90", Offset = "0x4D9B090", VA = "0x184D9CA90")]
	public GMEIMEMACBJ(BNHNNGJEGNL[] EBCFEOGANJK, bool KJLOOIBMLFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C8E0", Offset = "0x4D9AEE0", VA = "0x184D9C8E0")]
	public int ODAIPHHDOOO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4D9BD30", Offset = "0x4D9A330", VA = "0x184D9BD30")]
	private int AHDGACIEBOM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C170", Offset = "0x4D9A770", VA = "0x184D9C170", Slot = "6")]
	protected virtual uint AMALCFIPABK(uint GOFLPLJKKOO, T KKGBKLFKCPO)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C1A0", Offset = "0x4D9A7A0", VA = "0x184D9C1A0")]
	public bool JAMFHEADPDN(T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C240", Offset = "0x4D9A840", VA = "0x184D9C240")]
	public int KDCCAPHMMIO(T KKGBKLFKCPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C820", Offset = "0x4D9AE20", VA = "0x184D9C820")]
	public T OAIFCNJJIAD(int KHMHPNKMLMD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C570", Offset = "0x4D9AB70", VA = "0x184D9C570")]
	public bool NIKECJDPHKD(T KKGBKLFKCPO, bool IMGCMBPEJPE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C610", Offset = "0x4D9AC10", VA = "0x184D9C610")]
	public bool NIKECJDPHKD(T KKGBKLFKCPO, int KHMHPNKMLMD, bool IMGCMBPEJPE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4D9C970", Offset = "0x4D9AF70", VA = "0x184D9C970")]
	private int OPCPACJKMOM(int IGHNHCKLCCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4D9CA10", Offset = "0x4D9B010", VA = "0x184D9CA10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4D9CA10", Offset = "0x4D9B010", VA = "0x184D9CA10", Slot = "4")]
	private IEnumerator<BNHNNGJEGNL> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CKMEAMFPAKH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> GEKOKKIKPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> DAEBEAACKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int DNACLDMKLJG;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x687B420", Offset = "0x6879A20", VA = "0x18687B420")]
	public static CKMEAMFPAKH<T> APOOHFPNCHO(int BJPLKLLFDMG = 0, int DNACLDMKLJG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x687BA30", Offset = "0x687A030", VA = "0x18687BA30")]
	public static CKMEAMFPAKH<T> NMJHAIELDMK(int BJPLKLLFDMG = 0, int DNACLDMKLJG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x687BCB0", Offset = "0x687A2B0", VA = "0x18687BCB0")]
	public CKMEAMFPAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x687BCE0", Offset = "0x687A2E0", VA = "0x18687BCE0")]
	public CKMEAMFPAKH(int BJPLKLLFDMG, int DNACLDMKLJG = int.MaxValue, bool CJPICGJOHMB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x687BB10", Offset = "0x687A110", VA = "0x18687BB10")]
	public T PMCFFHGKNGL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x687B950", Offset = "0x6879F50", VA = "0x18687B950")]
	public void MFOHPABGFFE(T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x687B650", Offset = "0x6879C50", VA = "0x18687B650")]
	private void IKCNLPAOPBA(T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x687B930", Offset = "0x6879F30", VA = "0x18687B930")]
	private void LKJJGDCKPGK(T KKGBKLFKCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x687B500", Offset = "0x6879B00", VA = "0x18687B500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x687B730", Offset = "0x6879D30", VA = "0x18687B730")]
	private void INCJJHBPFLC(IEnumerable<T> NIJLHKNCLKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class CKGKKMBEKCB<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> JJAIEIEJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T IOLJDPJOMFM;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T IMGFNAHIACA
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x68777B0", Offset = "0x6875DB0", VA = "0x1868777B0")]
	public bool MOIPAGPLCIG(T KKGBKLFKCPO, int FKHLDNNBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x55F1680", Offset = "0x55EFC80", VA = "0x1855F1680")]
	public bool LHGDLAOELLI(int FKHLDNNBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x6877330", Offset = "0x6875930", VA = "0x186877330")]
	public T CKFMENIGLNG(int APELOBNKFAB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x6877880", Offset = "0x6875E80", VA = "0x186877880")]
	private bool POFMPFMBLIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x6877830", Offset = "0x6875E30", VA = "0x186877830")]
	public bool OMCPIMBCGII(int FKHLDNNBKMB, [Out] T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x55F3940", Offset = "0x55F1F40", VA = "0x1855F3940")]
	public CKGKKMBEKCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class EGNPIPIJCNG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct DBOOGDKFBMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T IBMJNNAJGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int PCEHILJIKLE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<DBOOGDKFBMD> GBIHKBDEEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T COICDCBOIKI;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x43253A0", Offset = "0x43239A0", VA = "0x1843253A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4785170", Offset = "0x4783770", VA = "0x184785170")]
	public bool JEFAFDBINCI(T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4785050", Offset = "0x4783650", VA = "0x184785050")]
	public void JDPCENHCAFL(T KKGBKLFKCPO, int FKHLDNNBKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4784EA0", Offset = "0x47834A0", VA = "0x184784EA0")]
	public bool BAFGFGCDOJB(T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4784FF0", Offset = "0x47835F0", VA = "0x184784FF0")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4784C60", Offset = "0x4783260", VA = "0x184784C60")]
	public T AOPCANGMOHN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x47856E0", Offset = "0x4783CE0", VA = "0x1847856E0")]
	protected void KLIGDFGPFBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x4785860", Offset = "0x4783E60", VA = "0x184785860")]
	public EGNPIPIJCNG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7F701B0", Offset = "0x7F6E7B0", VA = "0x187F701B0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7F70480", Offset = "0x7F6EA80", VA = "0x187F70480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7F70390", Offset = "0x7F6E990", VA = "0x187F70390")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7F70100", Offset = "0x7F6E700", VA = "0x187F70100")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7F703D0", Offset = "0x7F6E9D0", VA = "0x187F703D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x7F702E0", Offset = "0x7F6E8E0", VA = "0x187F702E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7F70070", Offset = "0x7F6E670", VA = "0x187F70070")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5AD1300", Offset = "0x5ACF900", VA = "0x185AD1300", Slot = "4")]
		public virtual T NGAJKMLJOCF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface ECLBPHMDMHP
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache HHPHIPMPBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public struct KOKDNCHLOAC<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> BGGFBGFNIID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool JCFOMFGGJBO;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1983E90", Offset = "0x1982490", VA = "0x181983E90")]
			public KOKDNCHLOAC(List<Component> BGGFBGFNIID, bool JCFOMFGGJBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x52E64A0", Offset = "0x52E4AA0", VA = "0x1852E64A0")]
			public DJILIGPANGK<T> DHKFMABLBKB()
			{
				return default(DJILIGPANGK<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x52E6510", Offset = "0x52E4B10", VA = "0x1852E6510", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x52E6510", Offset = "0x52E4B10", VA = "0x1852E6510", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct DJILIGPANGK<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> BGGFBGFNIID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool JCFOMFGGJBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int KHMHPNKMLMD;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T CGHPBCAOGAD
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x6D15950", Offset = "0x6D13F50", VA = "0x186D15950", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x6D158E0", Offset = "0x6D13EE0", VA = "0x186D158E0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x6D15920", Offset = "0x6D13F20", VA = "0x186D15920")]
			public DJILIGPANGK(List<Component> BGGFBGFNIID, bool JCFOMFGGJBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x6D15820", Offset = "0x6D13E20", VA = "0x186D15820", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x6D15830", Offset = "0x6D13E30", VA = "0x186D15830", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x47F73E0", Offset = "0x47F59E0", VA = "0x1847F73E0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x7F71EB0", Offset = "0x7F704B0", VA = "0x187F71EB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7F718B0", Offset = "0x7F6FEB0", VA = "0x187F718B0")]
		private void FLMOPKJJIJF(GameObject JLCFNKJMHLL, bool KKBNDFNEENM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7F71820", Offset = "0x7F6FE20", VA = "0x187F71820")]
		public static void FLMOPKJJIJF(GameObject JLCFNKJMHLL, ToolHierarchyCache BBCMOCJMBOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7F71790", Offset = "0x7F6FD90", VA = "0x187F71790")]
		public void BNODIPNIJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCB10", Offset = "0x3ECB110", VA = "0x183ECCB10")]
		public void GGLBAMCKLJF<T>(Action<T> CJDOILFHDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCAA0", Offset = "0x3ECB0A0", VA = "0x183ECCAA0")]
		public T GFLMODGCOIL<T>(bool JCFOMFGGJBO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x3ECCD30", Offset = "0x3ECB330", VA = "0x183ECCD30")]
		public KOKDNCHLOAC<T> HDHDFKABEJL<T>(bool JCFOMFGGJBO = false) where T : class
		{
			return default(KOKDNCHLOAC<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7F71A20", Offset = "0x7F70020", VA = "0x187F71A20")]
		public List<Component> GILNLHHCAEB(Type JLPANLJHHFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7F717A0", Offset = "0x7F6FDA0", VA = "0x187F717A0", Slot = "4")]
		public bool Equals(ToolHierarchyCache POMHCCBBBGD, ToolHierarchyCache JKKMGDMGNFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x7F71DB0", Offset = "0x7F703B0", VA = "0x187F71DB0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache ODCICEDDLMB)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class BCMKNFODKKM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int BJPLKLLFDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int AKHOHCBIBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> BGKLAKBENNH;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int DFHEGHDHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4C8EE70", Offset = "0x4C8D470", VA = "0x184C8EE70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T KCBIGOIHHPC
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x613F6F0", Offset = "0x613DCF0", VA = "0x18613F6F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T JPGAHKHGLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x613FBF0", Offset = "0x613E1F0", VA = "0x18613FBF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T ODCBDPFBKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x613F830", Offset = "0x613DE30", VA = "0x18613F830")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x613FD50", Offset = "0x613E350", VA = "0x18613FD50")]
	public BCMKNFODKKM(int BJPLKLLFDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x613FA00", Offset = "0x613E000", VA = "0x18613FA00")]
	public void JDPCENHCAFL(T AHLFFGHFCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x613F8D0", Offset = "0x613DED0", VA = "0x18613F8D0")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x613FC80", Offset = "0x613E280", VA = "0x18613FC80")]
	public void ODBBIPBNKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x613F5E0", Offset = "0x613DBE0", VA = "0x18613F5E0")]
	public void AGMIENBMNHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x613F8C0", Offset = "0x613DEC0", VA = "0x18613F8C0")]
	public void HABAPFBGCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x613FB10", Offset = "0x613E110", VA = "0x18613FB10")]
	public List<T> KCAACOKAHNP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class MBHNGAIONMF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct NOGGHOJLFAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int PCEHILJIKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T IBMJNNAJGNM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, NOGGHOJLFAA> JJAIEIEJJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> PBHKDMAHCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T IOLJDPJOMFM;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T IMGFNAHIACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xDED9A0", Offset = "0xDEBFA0", VA = "0x180DED9A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x55F9C90", Offset = "0x55F8290", VA = "0x1855F9C90", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool LDLDDGMKCIH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x55F9CE0", Offset = "0x55F82E0", VA = "0x1855F9CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object GIOIHENBMOA
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x55FA450", Offset = "0x55F8A50", VA = "0x1855FA450")]
	public bool MOIPAGPLCIG(T KKGBKLFKCPO, object DKFMAIJGPFL, int FKHLDNNBKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x55F9D30", Offset = "0x55F8330", VA = "0x1855F9D30")]
	public bool LHGDLAOELLI(object DKFMAIJGPFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x55FABD0", Offset = "0x55F91D0", VA = "0x1855FABD0")]
	public bool OMCPIMBCGII(object DKFMAIJGPFL, [Out] T KKGBKLFKCPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x55F9CB0", Offset = "0x55F82B0", VA = "0x1855F9CB0")]
	public void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x55FC2D0", Offset = "0x55FA8D0", VA = "0x1855FC2D0")]
	private bool POFMPFMBLIH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x55FDAE0", Offset = "0x55FC0E0", VA = "0x1855FDAE0")]
	public MBHNGAIONMF()
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
