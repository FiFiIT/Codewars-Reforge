function toCamelCase(str) {
  return str.replace(/[-_](\w)/g, (m) => m.slice(1).toUpperCase());
}

export { toCamelCase };
