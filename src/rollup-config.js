import rollup from 'rollup';
import nodeResolve from 'rollup-plugin-node-resolve';
import commonjs from 'rollup-plugin-commonjs';
import uglify from 'rollup-plugin-uglify';

var config =  {
	entry: 'app/main.js',
	dest: 'dist/build.js', // output a single application bundle
	sourceMap: true,
	sourceMapFile: 'dist/build.js.map',
	format: 'iife',
	onwarn: function(warning) {
		// Skip certain warnings
		// should intercept ... but doesn't in some rollup versions
		if ( warning.code === 'THIS_IS_UNDEFINED' ) { return; }
		// intercepts in some rollup versions
		if ( warning.indexOf("The 'this' keyword is equivalent to 'undefined'") > -1 ) { return; }
		// console.warn everything else
		console.warn( warning.message );
	},
	plugins: [
		nodeResolve({jsnext: true, module: true}),
		commonjs({
			include: 'node_modules/rxjs/**',
		}),
		uglify()
	]
}

export default config;
